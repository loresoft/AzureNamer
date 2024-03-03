using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class OrganizationEndpoint : EntityCommandEndpointBase<int, OrganizationReadModel, OrganizationReadModel, OrganizationCreateModel, OrganizationUpdateModel>
{
    public OrganizationEndpoint(IMediator mediator) : base(mediator, "Organization")
    {

    }

}

