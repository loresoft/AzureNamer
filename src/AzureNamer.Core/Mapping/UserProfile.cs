using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class UserProfile
    : AutoMapper.Profile
{
    public UserProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.User, AzureNamer.Shared.Models.UserReadModel>();

        CreateMap<AzureNamer.Shared.Models.UserCreateModel, AzureNamer.Core.Data.Entities.User>();

        CreateMap<AzureNamer.Core.Data.Entities.User, AzureNamer.Shared.Models.UserUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.UserUpdateModel, AzureNamer.Core.Data.Entities.User>();

        CreateMap<AzureNamer.Shared.Models.UserReadModel, AzureNamer.Shared.Models.UserUpdateModel>();

    }

}
