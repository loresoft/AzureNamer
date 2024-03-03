using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class OrganizationProfile
    : AutoMapper.Profile
{
    public OrganizationProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Organization, AzureNamer.Shared.Models.OrganizationReadModel>();

        CreateMap<AzureNamer.Shared.Models.OrganizationCreateModel, AzureNamer.Core.Data.Entities.Organization>();

        CreateMap<AzureNamer.Core.Data.Entities.Organization, AzureNamer.Shared.Models.OrganizationUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.OrganizationUpdateModel, AzureNamer.Core.Data.Entities.Organization>();

        CreateMap<AzureNamer.Shared.Models.OrganizationReadModel, AzureNamer.Shared.Models.OrganizationUpdateModel>();

    }

}
