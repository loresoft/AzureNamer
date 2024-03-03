using Blazored.Modal;

using AzureNamer.Client.Components;
using AzureNamer.Client.Extensions;
using AzureNamer.Client.Pages.Organizations.Components;
using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

using LoreSoft.Blazor.Controls;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using AzureNamer.Client.Services;
using System.Reflection;

namespace AzureNamer.Client.Pages.Organizations;

[Authorize]
public partial class Invites : OrganizationBase
{
    [Inject]
    public InviteRepository InviteRepository { get; set; } = null!;


    private DataGrid<InviteReadModel>? DataGrid { get; set; }


    private async ValueTask<DataResult<InviteReadModel>> LoadData(DataRequest request)
    {
        try
        {
            var query = QueryBuilder.CreateQuery(request);
            var result = await InviteRepository.Select(query);

            return new DataResult<InviteReadModel>(0, result);
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
            return new DataResult<InviteReadModel>(0, Enumerable.Empty<InviteReadModel>());
        }
    }

    private async Task HandleSendInvite(InviteReadModel invite)
    {
        try
        {
            var name = invite.Name;

            var parameters = new ModalParameters
            {
                { nameof(ConfirmModal.Message), $"Are you sure you want to send invite email to '{name}'?" },
                { nameof(ConfirmModal.ActionClass), "btn-primary" },
                { nameof(ConfirmModal.ActionName), "Send" }
            };

            var messageForm = Modal.Show<ConfirmModal>("Confirm Send", parameters);
            var result = await messageForm.Result;

            if (result.Cancelled)
                return;


            await InviteRepository.Send(invite.Id);
            NotificationService.ShowSuccess($"Invite to '{name}' sent successfully");

            await RefreshGrid();
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }

    private async Task HandleDeleteInvite(InviteReadModel invite)
    {
        if (invite == null)
            return;

        try
        {
            var name = invite.Name;

            if (!await Modal.ConfirmDelete($"Are you sure you want to delete invite for '{name}'?"))
                return;


            await InviteRepository.Delete(invite.Id);
            NotificationService.ShowSuccess($"Invite '{name}' deleted successfully");

            await RefreshGrid();
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }

    private async Task HandleNewInvite()
    {
        try
        {
            var parameters = new ModalParameters
            {
                { nameof(OrganizationInviteModal.Organization), OrganizationStore.Original }
            };

            var messageForm = Modal.Show<OrganizationInviteModal>("Send Invite", parameters);
            var result = await messageForm.Result;

            if (result.Cancelled)
                return;

            await RefreshGrid();
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }

    }

    private async Task RefreshGrid()
    {
        StateHasChanged();
        if (DataGrid != null)
            await DataGrid.RefreshAsync();
    }
}
