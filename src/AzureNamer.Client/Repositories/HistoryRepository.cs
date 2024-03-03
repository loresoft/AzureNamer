using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class HistoryRepository : RepositoryUpdateBase<int, HistoryReadModel, HistoryReadModel, HistoryUpdateModel>
{
    public HistoryRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/History";
}

