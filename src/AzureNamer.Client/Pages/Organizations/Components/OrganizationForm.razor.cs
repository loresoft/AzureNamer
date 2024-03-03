using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations.Components;

public partial class OrganizationForm
{
    [Inject]
    public OrganizationStore OrganizationStore { get; set; } = null!;

    [Inject]
    public UserStore UserStore { get; set; } = null!;

    public OrganizationUpdateModel? Organization => OrganizationStore.Model;

    protected bool IsOwner() => true; // Organization?.Members?.Any(m => m.Id == UserStore?.Model?.Id && m.IsOwner) == true;
}
