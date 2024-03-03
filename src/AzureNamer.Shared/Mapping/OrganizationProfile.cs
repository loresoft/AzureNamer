namespace AzureNamer.Shared.Mapping;

public partial class OrganizationProfile
    : AutoMapper.Profile
{
    public OrganizationProfile()
    {
        CreateMap<AzureNamer.Shared.Models.OrganizationReadModel, AzureNamer.Shared.Models.OrganizationUpdateModel>();
    }

}
