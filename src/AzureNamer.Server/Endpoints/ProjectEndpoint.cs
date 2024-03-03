using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class ProjectEndpoint : EntityCommandEndpointBase<int, ProjectReadModel, ProjectReadModel, ProjectCreateModel, ProjectUpdateModel>
{
    public ProjectEndpoint(IMediator mediator) : base(mediator, "Project")
    {

    }

}

