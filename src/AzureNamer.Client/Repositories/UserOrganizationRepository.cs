using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class UserOrganizationRepository : RepositoryUpdateBase<int, UserOrganizationReadModel, UserOrganizationReadModel, UserOrganizationUpdateModel>
{
    public UserOrganizationRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/UserOrganization";
}

