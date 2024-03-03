using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class LocationRepository : RepositoryUpdateBase<int, LocationReadModel, LocationReadModel, LocationUpdateModel>
{
    public LocationRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Location";
}

