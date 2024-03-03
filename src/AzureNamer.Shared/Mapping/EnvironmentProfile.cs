namespace AzureNamer.Shared.Mapping;

public partial class EnvironmentProfile
    : AutoMapper.Profile
{
    public EnvironmentProfile()
    {
        CreateMap<Models.EnvironmentReadModel, Models.EnvironmentUpdateModel>();
    }
}
