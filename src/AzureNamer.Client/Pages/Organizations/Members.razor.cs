using AzureNamer.Client.Extensions;
using AzureNamer.Client.Repositories;
using AzureNamer.Client.Services;
using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using LoreSoft.Blazor.Controls;

using MediatR.CommandQuery.Queries;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations;

[Authorize]
public partial class Members : OrganizationBase
{
    [Inject]
    public UserRepository UserRepository { get; set; } = null!;

    [Inject]
    public UserOrganizationRepository UserOrganizationRepository { get; set; } = null!;

    private DataGrid<UserOrganizationReadModel>? DataGrid { get; set; }

    private UserReadModel? SelectedUser { get; set; }


    protected bool IsSelf(int id)
    {
        return UserStore.Model?.UserId == id;
    }

    private async ValueTask<DataResult<UserOrganizationReadModel>> LoadData(DataRequest request)
    {
        try
        {
            var query = QueryBuilder.CreateQuery(request);

            var result = await UserOrganizationRepository.Select(query);

            return new DataResult<UserOrganizationReadModel>(0, result);
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);

            return new DataResult<UserOrganizationReadModel>(0, Enumerable.Empty<UserOrganizationReadModel>());
        }
    }

    protected async Task HandleToggleOwner(UserOrganizationReadModel model)
    {
        if (model == null)
            return;

        try
        {
            var userOrganization = new UserOrganizationUpdateModel
            {
                OrganizationId = model.OrganizationId,
                UserId = model.UserId,
                IsOwner = !model.IsOwner
            };

            await UserOrganizationRepository.Save(userOrganization, model.Id);

            await RefreshGrid();
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }


    protected async Task HandleRemoveUser(UserOrganizationReadModel model)
    {
        if (model == null)
            return;

        try
        {
            var name = model.UserName;

            if (!await Modal.ConfirmDelete($"Are you sure you want to remove '{name}'?"))
                return;

            await UserOrganizationRepository.Delete(model.Id);

            await RefreshGrid();

        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }

    protected async Task HandleAddUser()
    {
        if (SelectedUser == null)
            return;

        try
        {
            var userOrganization = new UserOrganizationUpdateModel
            {
                OrganizationId = OrganizationStore.Original!.Id,
                UserId = SelectedUser.Id,
                IsOwner = false
            };
            await UserOrganizationRepository.Save(userOrganization, 0);

            await RefreshGrid();

        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }

        SelectedUser = null;
    }

    protected async Task<IEnumerable<UserReadModel>> SearchUsers(string searchText)
    {
        try
        {
            if (string.IsNullOrEmpty(searchText))
                return Enumerable.Empty<UserReadModel>();

            var searchFields = new List<string>()
            {
                nameof(UserReadModel.Name),
                nameof(UserReadModel.Email)
            };
            var filter = QueryBuilder.SearchFilter(searchText, searchFields);
            if (filter == null)
                return Enumerable.Empty<UserReadModel>();

            var sort = new EntitySort { Name = nameof(UserReadModel.Name) };
            var query = new EntitySelect(filter, sort);

            return await UserRepository.Select(query);
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
            return Enumerable.Empty<UserReadModel>();
        }
    }

    private async Task RefreshGrid()
    {
        StateHasChanged();
        if (DataGrid != null)
            await DataGrid.RefreshAsync();
    }

}
