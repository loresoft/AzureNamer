namespace AzureNamer.Shared.Mapping;

public partial class SegmentProfile
    : AutoMapper.Profile
{
    public SegmentProfile()
    {
        CreateMap<AzureNamer.Shared.Models.SegmentReadModel, AzureNamer.Shared.Models.SegmentUpdateModel>();
    }

}
