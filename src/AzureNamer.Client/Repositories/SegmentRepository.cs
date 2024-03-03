using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class SegmentRepository : RepositoryUpdateBase<int, SegmentReadModel, SegmentReadModel, SegmentUpdateModel>
{
    public SegmentRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Segment";
}

