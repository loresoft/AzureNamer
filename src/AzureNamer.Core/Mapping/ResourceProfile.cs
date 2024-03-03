using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class ResourceProfile
    : AutoMapper.Profile
{
    public ResourceProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Resource, AzureNamer.Shared.Models.ResourceReadModel>();

        CreateMap<AzureNamer.Shared.Models.ResourceCreateModel, AzureNamer.Core.Data.Entities.Resource>();

        CreateMap<AzureNamer.Core.Data.Entities.Resource, AzureNamer.Shared.Models.ResourceUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.ResourceUpdateModel, AzureNamer.Core.Data.Entities.Resource>();

        CreateMap<AzureNamer.Shared.Models.ResourceReadModel, AzureNamer.Shared.Models.ResourceUpdateModel>();

    }

}
