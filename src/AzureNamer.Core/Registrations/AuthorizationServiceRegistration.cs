using AzureNamer.Core.Commands;
using AzureNamer.Core.Handlers;
using AzureNamer.Shared.Models;

using MediatR;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AzureNamer.Core.Registrations;

public class AuthorizationServiceRegistration
{
    [RegisterServices]
    public void Register(IServiceCollection services)
    {
        services.TryAddTransient<IRequestHandler<AuthorizationCommand, UserMembership>, AuthorizationHandler>();
    }
}
