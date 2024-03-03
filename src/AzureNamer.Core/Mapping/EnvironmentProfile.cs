using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class EnvironmentProfile
    : AutoMapper.Profile
{
    public EnvironmentProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Environment, AzureNamer.Shared.Models.EnvironmentReadModel>();

        CreateMap<AzureNamer.Shared.Models.EnvironmentCreateModel, AzureNamer.Core.Data.Entities.Environment>();

        CreateMap<AzureNamer.Core.Data.Entities.Environment, AzureNamer.Shared.Models.EnvironmentUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.EnvironmentUpdateModel, AzureNamer.Core.Data.Entities.Environment>();

        CreateMap<AzureNamer.Shared.Models.EnvironmentReadModel, AzureNamer.Shared.Models.EnvironmentUpdateModel>();

    }

}
