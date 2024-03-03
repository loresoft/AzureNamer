namespace AzureNamer.Shared.Mapping;

public partial class ProjectProfile
    : AutoMapper.Profile
{
    public ProjectProfile()
    {
        CreateMap<AzureNamer.Shared.Models.ProjectReadModel, AzureNamer.Shared.Models.ProjectUpdateModel>();
    }

}
