namespace AzureNamer.Client.Stores;

public abstract class StoreBase<TModel> : StateBase<TModel>
    where TModel : class, new()
{

    protected StoreBase(ILoggerFactory loggerFactory)
    {
        Logger = loggerFactory.CreateLogger(GetType());
    }

    public ILogger Logger { get; }

    public override void Set(TModel model)
    {
        Model = model;

        Logger.LogDebug("Store model '{modelType}' changed.", typeof(TModel).Name);
        NotifyStateChanged();
    }

    public virtual void Clear()
    {
        Model = default;

        Logger.LogDebug("Store model '{modelType}' cleared.", typeof(TModel).Name);
        NotifyStateChanged();
    }

    public virtual void New()
    {
        Model = new TModel();

        Logger.LogDebug("Store model '{modelType}' created.", typeof(TModel).Name);
        NotifyStateChanged();
    }
}
