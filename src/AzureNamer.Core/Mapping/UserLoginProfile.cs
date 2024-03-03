using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class UserLoginProfile
    : AutoMapper.Profile
{
    public UserLoginProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.UserLogin, AzureNamer.Shared.Models.UserLoginReadModel>();

    }

}
