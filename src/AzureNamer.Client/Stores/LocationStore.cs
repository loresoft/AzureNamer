using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class LocationStore : StoreEditBase<LocationRepository, int, LocationReadModel, LocationReadModel, LocationUpdateModel>
{
    public LocationStore(ILoggerFactory loggerFactory, LocationRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

