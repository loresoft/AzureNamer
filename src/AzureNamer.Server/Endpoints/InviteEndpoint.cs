using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class InviteEndpoint : EntityCommandEndpointBase<int, InviteReadModel, InviteReadModel, InviteCreateModel, InviteUpdateModel>
{
    public InviteEndpoint(IMediator mediator) : base(mediator, "Invite")
    {

    }

}

