using System;
using AutoMapper;
using AzureNamer.Core.Data.Entities;
using AzureNamer.Shared.Models;

namespace AzureNamer.Core.Mapping;

public partial class InviteProfile
    : AutoMapper.Profile
{
    public InviteProfile()
    {
        CreateMap<AzureNamer.Core.Data.Entities.Invite, AzureNamer.Shared.Models.InviteReadModel>();

        CreateMap<AzureNamer.Shared.Models.InviteCreateModel, AzureNamer.Core.Data.Entities.Invite>();

        CreateMap<AzureNamer.Core.Data.Entities.Invite, AzureNamer.Shared.Models.InviteUpdateModel>();

        CreateMap<AzureNamer.Shared.Models.InviteUpdateModel, AzureNamer.Core.Data.Entities.Invite>();

        CreateMap<AzureNamer.Shared.Models.InviteReadModel, AzureNamer.Shared.Models.InviteUpdateModel>();

    }

}
