using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class SegmentProfile
    : AutoMapper.Profile
{
    public SegmentProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Segment, AzureNamer.Shared.Models.SegmentReadModel>();

        CreateMap<AzureNamer.Shared.Models.SegmentCreateModel, AzureNamer.Core.Data.Entities.Segment>();

        CreateMap<AzureNamer.Core.Data.Entities.Segment, AzureNamer.Shared.Models.SegmentUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.SegmentUpdateModel, AzureNamer.Core.Data.Entities.Segment>();

        CreateMap<AzureNamer.Shared.Models.SegmentReadModel, AzureNamer.Shared.Models.SegmentUpdateModel>();

    }

}
