namespace AzureNamer.Shared.Mapping;

public partial class UserProfile
    : AutoMapper.Profile
{
    public UserProfile()
    {
        CreateMap<AzureNamer.Shared.Models.UserReadModel, AzureNamer.Shared.Models.UserUpdateModel>();
    }

}
