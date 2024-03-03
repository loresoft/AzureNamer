using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class UnitEndpoint : EntityCommandEndpointBase<int, UnitReadModel, UnitReadModel, UnitCreateModel, UnitUpdateModel>
{
    public UnitEndpoint(IMediator mediator) : base(mediator, "Unit")
    {

    }

}

