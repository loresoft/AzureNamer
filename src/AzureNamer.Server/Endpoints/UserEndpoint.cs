using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class UserEndpoint : EntityCommandEndpointBase<int, UserReadModel, UserReadModel, UserCreateModel, UserUpdateModel>
{
    public UserEndpoint(IMediator mediator) : base(mediator, "User")
    {

    }

}

