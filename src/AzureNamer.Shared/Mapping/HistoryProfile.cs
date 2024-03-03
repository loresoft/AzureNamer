namespace AzureNamer.Shared.Mapping;

public partial class HistoryProfile
    : AutoMapper.Profile
{
    public HistoryProfile()
    {
        CreateMap<AzureNamer.Shared.Models.HistoryReadModel, AzureNamer.Shared.Models.HistoryUpdateModel>();

    }

}
