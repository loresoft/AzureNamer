using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class EnvironmentEndpoint : EntityCommandEndpointBase<int, EnvironmentReadModel, EnvironmentReadModel, EnvironmentCreateModel, EnvironmentUpdateModel>
{
    public EnvironmentEndpoint(IMediator mediator) : base(mediator, "Environment")
    {

    }

}

