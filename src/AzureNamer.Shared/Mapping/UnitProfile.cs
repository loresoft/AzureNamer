namespace AzureNamer.Shared.Mapping;

public partial class UnitProfile
    : AutoMapper.Profile
{
    public UnitProfile()
    {
        CreateMap<AzureNamer.Shared.Models.UnitReadModel, AzureNamer.Shared.Models.UnitUpdateModel>();
    }

}
