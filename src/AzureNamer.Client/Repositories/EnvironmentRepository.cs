using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class EnvironmentRepository : RepositoryUpdateBase<int, EnvironmentReadModel, EnvironmentReadModel, EnvironmentUpdateModel>
{
    public EnvironmentRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Environment";
}

