using System;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class SegmentStore : StoreEditBase<SegmentRepository, int, SegmentReadModel, SegmentReadModel, SegmentUpdateModel>
{
    public SegmentStore(ILoggerFactory loggerFactory, SegmentRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }

}

