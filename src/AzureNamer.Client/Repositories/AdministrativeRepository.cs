using System.Net.Http.Json;

using AzureNamer.Client.Services;
using AzureNamer.Shared.Models;

using FluentRest;

using MediatR.CommandQuery.Queries;

namespace AzureNamer.Client.Repositories;

[RegisterScoped]
public class AdministrativeRepository
{
    protected GatewayClient Gateway { get; }

    public AdministrativeRepository(GatewayClient gateway)
    {
        Gateway = gateway;
    }

    public async Task<UserReadModel> LoadUser(int id)
    {
        return await Gateway.GetAsync<UserReadModel>(b => b
            .AppendPath("/api/administrative/users")
            .AppendPath(id)
        );
    }

    public async Task<EntityPagedResult<UserReadModel>> SearchUsers(EntityQuery queryRequest)
    {
        if (queryRequest is null)
            throw new ArgumentNullException(nameof(queryRequest));

        return await Gateway.PostAsync<EntityPagedResult<UserReadModel>>(b => b
            .AppendPath("/api/administrative/users")
        );
    }

    public async Task<OrganizationReadModel> LoadOrganization(int id)
    {
        return await Gateway.GetAsync<OrganizationReadModel>(b => b
            .AppendPath("/api/administrative/organizations")
            .AppendPath(id)
        );
    }

    public async Task<EntityPagedResult<OrganizationReadModel>> SearchOrganizations(EntityQuery queryRequest)
    {
        if (queryRequest is null)
            throw new ArgumentNullException(nameof(queryRequest));

        return await Gateway.PostAsync<EntityPagedResult<OrganizationReadModel>>(b => b
            .AppendPath("/api/administrative/organizations")
        );
    }

}
