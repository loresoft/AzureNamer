namespace AzureNamer.Shared.Mapping;

public partial class InviteProfile
    : AutoMapper.Profile
{
    public InviteProfile()
    {
        CreateMap<AzureNamer.Shared.Models.InviteReadModel, AzureNamer.Shared.Models.InviteUpdateModel>();

    }

}
