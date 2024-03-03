using System.Reflection;
using System.Text.Json;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Extensions;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Client.Stores;

public abstract class StoreEditBase<TRepository, TKey, TListModel, TReadModel, TUpdateModel>  : StoreBase<TUpdateModel>
    where TRepository : RepositoryUpdateBase<TKey, TListModel, TReadModel, TUpdateModel>
    where TReadModel : class, IHaveIdentifier<TKey>, new()
    where TUpdateModel : class, new()
{

    protected StoreEditBase(ILoggerFactory loggerFactory, TRepository repository, IMapper mapper) : base(loggerFactory)
    {
        Repository = repository;
        Mapper = mapper;
    }

    public IMapper Mapper { get; }

    public TRepository Repository { get; }

    public TReadModel? Original { get; protected set; }

    public int EditHash { get; protected set; }

    public bool IsBusy { get; protected set; }

    public bool IsDirty => Model?.GetHashCode() != EditHash;

    public bool IsClean => Model?.GetHashCode() == EditHash;


    public override void Set(TUpdateModel model)
    {
        EditHash = model.GetHashCode();
        Model = model;

        Logger.LogDebug("Store model '{modelType}' changed.", typeof(TUpdateModel).Name);
        NotifyStateChanged();
    }

    public override void Clear()
    {
        SetModel(null);

        Logger.LogDebug("Store model '{modelType}' cleared.", typeof(TUpdateModel).Name);
        NotifyStateChanged();
    }

    public override void New()
    {
        SetModel(new TReadModel());

        Logger.LogDebug("Store model '{modelType}' created.", typeof(TUpdateModel).Name);
        NotifyStateChanged();
    }


    public async Task Load(TKey id, bool force = false)
    {
        // don't load if already loaded
        if (!force && Original != null && EqualityComparer<TKey>.Default.Equals(Original.Id, id))
            return;

        try
        {
            IsBusy = true;

            // load read modal
            var readModel = await Repository.Get(id);

            SetModel(readModel);
        }
        finally
        {
            IsBusy = false;
            NotifyStateChanged();
        }
    }

    public async Task Save()
    {
        try
        {
            IsBusy = true;

            // get key from original
            var key = Original != null ? Original.Id : default;
            var readModel = await Repository.Save(Model, key);

            SetModel(readModel);
        }
        finally
        {
            IsBusy = false;
            NotifyStateChanged();
        }
    }

    public async Task Delete(TKey id)
    {
        if (Model == null)
            return;

        try
        {
            IsBusy = true;

            await Repository.Delete(id);

            SetModel(null);
        }
        finally
        {
            IsBusy = false;
            NotifyStateChanged();
        }
    }


    protected void SetModel(TReadModel? model)
    {
        if (model == null)
        {
            Original = null;

            Model = null;
            EditHash = 0;
        }
        else
        {
            Original = model;

            // convert read to update model
            Model = Mapper.Map<TUpdateModel>(model);

            // save hash to track changes
            EditHash = Model.GetHashCode();
        }
    }

}
