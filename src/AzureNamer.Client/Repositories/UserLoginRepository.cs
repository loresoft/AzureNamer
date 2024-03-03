using System;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class UserLoginRepository : RepositoryQueryBase<int, UserLoginReadModel, UserLoginReadModel>
{
    public UserLoginRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/UserLogin";
}

