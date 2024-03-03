using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class UnitProfile
    : AutoMapper.Profile
{
    public UnitProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Unit, AzureNamer.Shared.Models.UnitReadModel>();

        CreateMap<AzureNamer.Shared.Models.UnitCreateModel, AzureNamer.Core.Data.Entities.Unit>();

        CreateMap<AzureNamer.Core.Data.Entities.Unit, AzureNamer.Shared.Models.UnitUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.UnitUpdateModel, AzureNamer.Core.Data.Entities.Unit>();

        CreateMap<AzureNamer.Shared.Models.UnitReadModel, AzureNamer.Shared.Models.UnitUpdateModel>();

    }

}
