using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class ResourceRepository : RepositoryUpdateBase<int, ResourceReadModel, ResourceReadModel, ResourceUpdateModel>
{
    public ResourceRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Resource";
}

