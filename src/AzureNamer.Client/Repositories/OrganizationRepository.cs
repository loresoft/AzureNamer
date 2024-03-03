using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class OrganizationRepository : RepositoryUpdateBase<int, OrganizationReadModel, OrganizationReadModel, OrganizationUpdateModel>
{
    public OrganizationRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Organization";
}

