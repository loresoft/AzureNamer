using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class UnitRepository : RepositoryUpdateBase<int, UnitReadModel, UnitReadModel, UnitUpdateModel>
{
    public UnitRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Unit";
}

