using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class LocationProfile
    : AutoMapper.Profile
{
    public LocationProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Location, AzureNamer.Shared.Models.LocationReadModel>();

        CreateMap<AzureNamer.Shared.Models.LocationCreateModel, AzureNamer.Core.Data.Entities.Location>();

        CreateMap<AzureNamer.Core.Data.Entities.Location, AzureNamer.Shared.Models.LocationUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.LocationUpdateModel, AzureNamer.Core.Data.Entities.Location>();

        CreateMap<AzureNamer.Shared.Models.LocationReadModel, AzureNamer.Shared.Models.LocationUpdateModel>();

    }

}
