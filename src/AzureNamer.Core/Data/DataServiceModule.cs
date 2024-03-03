using AzureNamer.Core.Data;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace InstructorIQ.Core.Data;

public class DataServiceModule
{
    [RegisterServices]
    public void Register(IServiceCollection services)
    {
        services.AddDbContext<AzureNamerContext>(
            optionsAction: (provider, options) =>
            {
                var configuration = provider.GetRequiredService<IConfiguration>();
                var connectionString = configuration.GetConnectionString("AzureNamer");
                options.UseSqlServer(connectionString, providerOptions => providerOptions.EnableRetryOnFailure());
            },
            contextLifetime: ServiceLifetime.Transient,
            optionsLifetime: ServiceLifetime.Transient
        );
    }
}
