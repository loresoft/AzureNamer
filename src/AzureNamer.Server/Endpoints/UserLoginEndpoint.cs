using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class UserLoginEndpoint : EntityQueryEndpointBase<int, UserLoginReadModel, UserLoginReadModel>
{
    public UserLoginEndpoint(IMediator mediator) : base(mediator, "UserLogin")
    {

    }

}

