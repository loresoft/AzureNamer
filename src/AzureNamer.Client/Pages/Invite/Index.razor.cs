using AzureNamer.Client.Repositories;
using AzureNamer.Client.Services;
using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Invite;

public partial class Index
{
    [Parameter]
    public string SecurityKey { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    [Inject]
    public NotificationService NotificationService { get; set; } = null!;

    [Inject]
    public InviteRepository InviteRepository { get; set; } = null!;

    [Inject]
    public UserStore UserStore { get; set; } = null!;

    private bool IsBusy { get; set; }

    private InviteReadModel? Invite { get; set; }

    protected override async Task OnInitializedAsync()
    {
        try
        {
            IsBusy = true;
            Invite = await InviteRepository.LoadByKey(SecurityKey);
        }
        catch (Exception ex)
        {

            NotificationService.ShowError(ex);
            Navigation.NavigateTo("/");
        }
        finally
        {
            IsBusy = false;
        }
    }

    protected async Task HandleAccept()
    {
        try
        {
            IsBusy = true;

            await InviteRepository.Redeem(SecurityKey);

            NotificationService.ShowSuccess($"Invite to '{Invite?.OrganizationName}' accepted successfully");
            Navigation.NavigateTo("/Account/Profile");
        }
        catch (Exception ex)
        {
            NotificationService.ShowError(ex);
        }
        finally
        {
            IsBusy = false;
        }
    }
}
