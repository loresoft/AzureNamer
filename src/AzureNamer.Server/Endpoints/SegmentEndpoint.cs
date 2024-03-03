using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class SegmentEndpoint : EntityCommandEndpointBase<int, SegmentReadModel, SegmentReadModel, SegmentCreateModel, SegmentUpdateModel>
{
    public SegmentEndpoint(IMediator mediator) : base(mediator, "Segment")
    {

    }

}

