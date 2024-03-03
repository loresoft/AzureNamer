namespace AzureNamer.Shared.Mapping;

public partial class LocationProfile
    : AutoMapper.Profile
{
    public LocationProfile()
    {
        CreateMap<AzureNamer.Shared.Models.LocationReadModel, AzureNamer.Shared.Models.LocationUpdateModel>();
    }

}
