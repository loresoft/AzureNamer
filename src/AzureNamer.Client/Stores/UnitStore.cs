using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class UnitStore : StoreEditBase<UnitRepository, int, UnitReadModel, UnitReadModel, UnitUpdateModel>
{
    public UnitStore(ILoggerFactory loggerFactory, UnitRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

