using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class UserOrganizationProfile
    : AutoMapper.Profile
{
    public UserOrganizationProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.UserOrganization, AzureNamer.Shared.Models.UserOrganizationReadModel>();

        CreateMap<AzureNamer.Shared.Models.UserOrganizationCreateModel, AzureNamer.Core.Data.Entities.UserOrganization>();

        CreateMap<AzureNamer.Core.Data.Entities.UserOrganization, AzureNamer.Shared.Models.UserOrganizationUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.UserOrganizationUpdateModel, AzureNamer.Core.Data.Entities.UserOrganization>();

        CreateMap<AzureNamer.Shared.Models.UserOrganizationReadModel, AzureNamer.Shared.Models.UserOrganizationUpdateModel>();

    }

}
