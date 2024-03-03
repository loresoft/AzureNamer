using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class ResourceStore : StoreEditBase<ResourceRepository, int, ResourceReadModel, ResourceReadModel, ResourceUpdateModel>
{
    public ResourceStore(ILoggerFactory loggerFactory, ResourceRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

