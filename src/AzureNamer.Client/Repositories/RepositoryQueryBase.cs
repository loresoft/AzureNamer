using AzureNamer.Client.Services;

using FluentRest;

using MediatR.CommandQuery.Queries;

namespace AzureNamer.Client.Repositories;

public abstract class RepositoryQueryBase<TKey, TListModel, TReadModel>
{
    protected RepositoryQueryBase(GatewayClient gateway)
    {
        Gateway = gateway ?? throw new ArgumentNullException(nameof(gateway));
    }


    protected GatewayClient Gateway { get; }


    public async Task<TReadModel?> Get(TKey id)
    {
        if (id == null || EqualityComparer<TKey>.Default.Equals(id, default))
            return default;

        return await Gateway.GetAsync<TReadModel>(b => b
            .AppendPath(GetBasePath())
            .AppendPath(id)
        );
    }

    public async Task<IReadOnlyCollection<TListModel>> Select(EntitySelect request)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request));

        return await Gateway.PostAsync<IReadOnlyCollection<TListModel>>(b => b
            .AppendPath(GetBasePath())
            .AppendPath("query")
        );
    }

    public async Task<EntityPagedResult<TListModel>> Page(EntityQuery request)
    {
        if (request is null)
            throw new ArgumentNullException(nameof(request));

        return await Gateway.PostAsync<EntityPagedResult<TListModel>>(b => b
            .AppendPath(GetBasePath())
            .AppendPath("page")
        );
    }


    protected abstract string GetBasePath();
}
