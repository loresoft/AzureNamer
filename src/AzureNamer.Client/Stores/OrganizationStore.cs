using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Models;

namespace AzureNamer.Client.Stores;

public class OrganizationStore : StoreEditBase<OrganizationRepository, int, OrganizationReadModel, OrganizationReadModel, OrganizationUpdateModel>
{
    public OrganizationStore(ILoggerFactory loggerFactory, OrganizationRepository repository, IMapper mapper) : base(loggerFactory, repository, mapper)
    {
    }
}
