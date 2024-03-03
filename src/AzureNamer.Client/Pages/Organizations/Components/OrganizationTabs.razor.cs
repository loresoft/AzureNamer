using AzureNamer.Client.Stores;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Components;

namespace AzureNamer.Client.Pages.Organizations.Components;

public partial class OrganizationTabs
{
    [Inject]
    public OrganizationStore OrganizationStore { get; set; } = null!;

    public OrganizationReadModel? Organization => OrganizationStore.Original;
}
