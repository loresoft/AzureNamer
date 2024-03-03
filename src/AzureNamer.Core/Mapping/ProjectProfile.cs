using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class ProjectProfile
    : AutoMapper.Profile
{
    public ProjectProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Project, AzureNamer.Shared.Models.ProjectReadModel>();

        CreateMap<AzureNamer.Shared.Models.ProjectCreateModel, AzureNamer.Core.Data.Entities.Project>();

        CreateMap<AzureNamer.Core.Data.Entities.Project, AzureNamer.Shared.Models.ProjectUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.ProjectUpdateModel, AzureNamer.Core.Data.Entities.Project>();

        CreateMap<AzureNamer.Shared.Models.ProjectReadModel, AzureNamer.Shared.Models.ProjectUpdateModel>();

    }

}
