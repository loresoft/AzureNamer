using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class SegmentTypeProfile
    : AutoMapper.Profile
{
    public SegmentTypeProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.SegmentType, AzureNamer.Shared.Models.SegmentTypeReadModel>();

    }

}
