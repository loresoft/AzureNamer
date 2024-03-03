using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class SegmentTypeRepository : RepositoryQueryBase<int, SegmentTypeReadModel, SegmentTypeReadModel>
{
    public SegmentTypeRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/SegmentType";
}

