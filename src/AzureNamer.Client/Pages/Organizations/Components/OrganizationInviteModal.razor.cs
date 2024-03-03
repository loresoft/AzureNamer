using Blazored.Modal;
using Blazored.Modal.Services;

using AzureNamer.Client.Repositories;
using AzureNamer.Client.Services;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations.Components;

public partial class OrganizationInviteModal
{
    [Parameter]
    public UserOrganizationReadModel Organization { get; set; } = null!;

    private bool IsBusy { get; set; }

    private InviteUpdateModel Invite { get; set; } = new();

    [CascadingParameter]
    private BlazoredModalInstance Modal { get; set; } = null!;

    [Inject]
    public NotificationService NotificationService { get; set; } = null!;

    [Inject]
    public InviteRepository InviteRepository { get; set; } = null!;

    private async Task HandleSave()
    {
        try
        {
            IsBusy = true;

            Invite.OrganizationId = Organization.Id;

            await InviteRepository.Save(Invite, 0);

            NotificationService.ShowSuccess($"Invite for '{Invite.Name}' sent successfully");

            await Modal.CloseAsync(ModalResult.Ok(true));
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

    private async Task Cancel() => await Modal.CancelAsync();
}
