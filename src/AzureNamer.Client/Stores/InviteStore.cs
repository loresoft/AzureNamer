using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class InviteStore : StoreEditBase<InviteRepository, int, InviteReadModel, InviteReadModel, InviteUpdateModel>
{
    public InviteStore(ILoggerFactory loggerFactory, InviteRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

