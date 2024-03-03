using AzureNamer.Client.Services;
using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using Blazored.Modal.Services;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations;

[Authorize]
public abstract class OrganizationBase : ComponentBase, IDisposable
{
    [Parameter]
    public int Id { get; set; }


    [CascadingParameter]
    public IModalService Modal { get; set; } = null!;

    [Inject]
    public NotificationService NotificationService { get; set; } = null!;

    [Inject]
    public OrganizationStore OrganizationStore { get; set; } = null!;

    [Inject]
    public NavigationManager Navigation { get; set; } = null!;

    [Inject]
    public UserMembershipStore UserStore { get; set; } = null!;


    public OrganizationUpdateModel? Organization => OrganizationStore.Model;

    public UserMembership? User => UserStore.Model;


    protected bool IsOwner() => false; //UserStore.Model?.Organizations.Any(m => m.Id == UserStore.Model?.UserId && m.IsOwner) == true;

    protected override async Task OnInitializedAsync()
    {
        OrganizationStore.OnChange += HandleModelChange;

        try
        {
            await OrganizationStore.Load(Id);
            if (OrganizationStore.Model == null)
                Navigation.NavigateTo("/organizations");
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
        OrganizationStore.OnChange -= HandleModelChange;
    }

}
