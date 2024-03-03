using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class LocationEndpoint : EntityCommandEndpointBase<int, LocationReadModel, LocationReadModel, LocationCreateModel, LocationUpdateModel>
{
    public LocationEndpoint(IMediator mediator) : base(mediator, "Location")
    {

    }

}

