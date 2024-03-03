
using AzureNamer.Client.Repositories;
using AzureNamer.Client.Services;
using AzureNamer.Shared.Models;

using LoreSoft.Blazor.Controls;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations;

[Authorize]
public partial class Index
{
    [Inject]
    public OrganizationRepository Repository { get; set; } = null!;

    [Inject]
    public NotificationService NotificationService { get; set; } = null!;


    private DataGrid<OrganizationReadModel> DataGrid { get; set; } = null!;

    private string? SearchText { get; set; }

    private async ValueTask<DataResult<OrganizationReadModel>> LoadData(DataRequest request)
    {
        try
        {
            var searchFields = new List<string>()
            {
                nameof(OrganizationReadModel.Name),
                nameof(OrganizationReadModel.Description),
                nameof(OrganizationReadModel.Abbreviation),
            };

            var query = QueryBuilder.CreateQuery(request, SearchText, searchFields);
            var result = await Repository.Page(query);

            return new DataResult<OrganizationReadModel>((int)result.Total, result.Data);
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
            return new DataResult<OrganizationReadModel>(0, Enumerable.Empty<OrganizationReadModel>());
        }
    }

    private async Task HandleSearch()
    {
        await DataGrid.RefreshAsync(true);
    }
}
