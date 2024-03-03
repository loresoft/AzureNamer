using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class UserRepository : RepositoryUpdateBase<int, UserReadModel, UserReadModel, UserUpdateModel>
{
    public UserRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/User";
}

