using AzureNamer.Client.Services;

using FluentRest;

namespace AzureNamer.Client.Repositories;

public abstract class RepositoryUpdateBase<TKey, TListModel, TReadModel, TUpdateModel>
    : RepositoryQueryBase<TKey, TListModel, TReadModel>
{
    protected RepositoryUpdateBase(GatewayClient gateway) : base(gateway)
    {
    }


    public async Task<TReadModel?> Save(TUpdateModel? model, TKey? id)
    {
        if (model == null)
            return default;

        return await Gateway.PostAsync<TReadModel>(b => b
            .AppendPath(GetBasePath())
            .AppendPath(id ?? default)
            .Content(model)
        );
    }

    public async Task<TReadModel?> Delete(TKey id)
    {
        if (id == null || EqualityComparer<TKey>.Default.Equals(id, default))
            return default;

        return await Gateway.DeleteAsync<TReadModel>(b => b
            .AppendPath(GetBasePath())
            .AppendPath(id ?? default)
        );
    }
}
