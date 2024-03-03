using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class EnvironmentStore : StoreEditBase<EnvironmentRepository, int, EnvironmentReadModel, EnvironmentReadModel, EnvironmentUpdateModel>
{
    public EnvironmentStore(ILoggerFactory loggerFactory, EnvironmentRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

