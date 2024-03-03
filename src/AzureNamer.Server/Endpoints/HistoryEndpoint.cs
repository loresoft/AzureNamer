using System;
using MediatR;
using MediatR.CommandQuery.Endpoints;
using AzureNamer.Shared.Models;

namespace AzureNamer.Server.Endpoints;

[RegisterTransient<IFeatureEndpoint>(Duplicate = DuplicateStrategy.Append)]
public class HistoryEndpoint : EntityCommandEndpointBase<int, HistoryReadModel, HistoryReadModel, HistoryCreateModel, HistoryUpdateModel>
{
    public HistoryEndpoint(IMediator mediator) : base(mediator, "History")
    {

    }

}

