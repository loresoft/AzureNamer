using AzureNamer.Client.Services;
using AzureNamer.Client.Stores;

using Blazored.Modal.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Account;

[Authorize]
public partial class Profile
{
    [CascadingParameter]
    public IModalService Modal { get; set; }

    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public NotificationService NotificationService { get; set; }

    [Inject]
    public UserStore UserStore { get; set; }


    protected override async Task OnInitializedAsync()
    {
        UserStore.OnChange += HandleModelChange;

        try
        {
            await UserStore.LoadCurrent();
            if (UserStore.Model == null)
                Navigation.NavigateTo("/");
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
    }

    protected async Task HandleSave()
    {
        try
        {
            await UserStore.Save();
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


    public void Dispose()
    {
        UserStore.OnChange -= HandleModelChange;
    }

}
