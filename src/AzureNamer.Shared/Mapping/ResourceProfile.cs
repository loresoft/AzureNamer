namespace AzureNamer.Shared.Mapping;

public partial class ResourceProfile
    : AutoMapper.Profile
{
    public ResourceProfile()
    {
        CreateMap<AzureNamer.Shared.Models.ResourceReadModel, AzureNamer.Shared.Models.ResourceUpdateModel>();
    }

}
