namespace AzureNamer.Shared.Mapping;

public partial class UserOrganizationProfile
    : AutoMapper.Profile
{
    public UserOrganizationProfile()
    {
        CreateMap<AzureNamer.Shared.Models.UserOrganizationReadModel, AzureNamer.Shared.Models.UserOrganizationUpdateModel>();
    }

}
