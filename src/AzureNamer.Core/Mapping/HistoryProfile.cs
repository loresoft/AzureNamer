using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class HistoryProfile
    : AutoMapper.Profile
{
    public HistoryProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.History, AzureNamer.Shared.Models.HistoryReadModel>();

        CreateMap<AzureNamer.Shared.Models.HistoryCreateModel, AzureNamer.Core.Data.Entities.History>();

        CreateMap<AzureNamer.Core.Data.Entities.History, AzureNamer.Shared.Models.HistoryUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.HistoryUpdateModel, AzureNamer.Core.Data.Entities.History>();

        CreateMap<AzureNamer.Shared.Models.HistoryReadModel, AzureNamer.Shared.Models.HistoryUpdateModel>();

    }

}
