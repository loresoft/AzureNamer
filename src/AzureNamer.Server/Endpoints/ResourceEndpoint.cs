using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class ResourceEndpoint : EntityCommandEndpointBase<int, ResourceReadModel, ResourceReadModel, ResourceCreateModel, ResourceUpdateModel>
{
    public ResourceEndpoint(IMediator mediator) : base(mediator, "Resource")
    {

    }

}

