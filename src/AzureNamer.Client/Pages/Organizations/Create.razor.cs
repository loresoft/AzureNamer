using AzureNamer.Client.Services;
using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace AzureNamer.Client.Pages.Organizations;

[Authorize]
public partial class Create : IDisposable
{
    [Inject]
    public NotificationService NotificationService { get; set; } = null!;

    [Inject]
    public OrganizationStore OrganizationStore { get; set; } = null!;

    [Inject]
    public UserStore UserStore { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;


    public OrganizationUpdateModel? Organization => OrganizationStore.Model;

    private EditContext EditContext { get; set; } = null!;


    protected override void OnInitialized()
    {
        OrganizationStore.OnChange += HandleModelChange;

        OrganizationStore.New();

        EditContext = new EditContext(OrganizationStore.Model);
        EditContext.OnFieldChanged += HandleFormChange;
    }

    protected async Task HandleSave()
    {
        try
        {
            await OrganizationStore.Save();

            NotificationService.ShowSuccess($"Organization '{OrganizationStore.Original.Name}' saved successfully");
            Navigation.NavigateTo($"/organizations/{OrganizationStore.Original.Id}");
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }

    private void HandleModelChange()
    {
        InvokeAsync(StateHasChanged);
    }

    private void HandleFormChange(object sender, FieldChangedEventArgs args)
    {
        OrganizationStore.NotifyStateChanged();
    }

    public void Dispose()
    {
        OrganizationStore.OnChange -= HandleModelChange;
        EditContext.OnFieldChanged -= HandleFormChange;
    }

}
