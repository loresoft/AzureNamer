using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class HistoryStore : StoreEditBase<HistoryRepository, int, HistoryReadModel, HistoryReadModel, HistoryUpdateModel>
{
    public HistoryStore(ILoggerFactory loggerFactory, HistoryRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

