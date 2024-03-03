using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class UserOrganizationEndpoint : EntityCommandEndpointBase<int, UserOrganizationReadModel, UserOrganizationReadModel, UserOrganizationCreateModel, UserOrganizationUpdateModel>
{
    public UserOrganizationEndpoint(IMediator mediator) : base(mediator, "UserOrganization")
    {

    }

}

