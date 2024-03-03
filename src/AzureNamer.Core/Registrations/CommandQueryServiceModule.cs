using AzureNamer.Core.Data;
using AzureNamer.Shared;

using MediatR.CommandQuery.EntityFrameworkCore;

using Microsoft.Extensions.DependencyInjection;

namespace AzureNamer.Core.Registrations;

public class CommandQueryServiceModule
{
    [RegisterServices]
    public void Register(IServiceCollection services)
    {
        services.AddMediator();
        services.AddAutoMapper(typeof(AzureNamerContext).Assembly, typeof(DomainJsonContext).Assembly);
    }
}
