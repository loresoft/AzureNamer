using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class ProjectRepository : RepositoryUpdateBase<int, ProjectReadModel, ProjectReadModel, ProjectUpdateModel>
{
    public ProjectRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Project";
}

