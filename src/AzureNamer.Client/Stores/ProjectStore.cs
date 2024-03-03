using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class ProjectStore : StoreEditBase<ProjectRepository, int, ProjectReadModel, ProjectReadModel, ProjectUpdateModel>
{
    public ProjectStore(ILoggerFactory loggerFactory, ProjectRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

