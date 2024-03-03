using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class SegmentTypeEndpoint : EntityQueryEndpointBase<int, SegmentTypeReadModel, SegmentTypeReadModel>
{
    public SegmentTypeEndpoint(IMediator mediator) : base(mediator, "SegmentType")
    {

    }

}

