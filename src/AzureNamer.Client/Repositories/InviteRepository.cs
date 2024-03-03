using System;

using AzureNamer.Shared.Models;

using FluentRest;

using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class InviteRepository : RepositoryUpdateBase<int, InviteReadModel, InviteReadModel, InviteUpdateModel>
{
    public InviteRepository(Services.GatewayClient gateway) : base(gateway)
    {
    }

    protected override string GetBasePath() => "/api/Invite";

    public async Task Send(int id)
    {
        var result = await Gateway.PostAsync(b => b
            .AppendPath(GetBasePath())
            .AppendPath(id)
            .AppendPath("send")
        );

        result.EnsureSuccessStatusCode();
    }

    public async Task Redeem(string securityKey)
    {
        if (securityKey is null)
            throw new ArgumentNullException(nameof(securityKey));

        var result = await Gateway.PostAsync(b => b
            .AppendPath(GetBasePath())
            .AppendPath("key")
            .AppendPath(securityKey)
            .AppendPath("redeem")
        );

        result.EnsureSuccessStatusCode();
    }

    public async Task<InviteReadModel> LoadByKey(string securityKey)
    {
        if (securityKey is null)
            throw new ArgumentNullException(nameof(securityKey));

        return await Gateway.GetAsync<InviteReadModel>(b => b
            .AppendPath(GetBasePath())
            .AppendPath("key")
            .AppendPath(securityKey)
        );
    }
}

