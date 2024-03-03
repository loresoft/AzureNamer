using System;
using System.Collections.Generic;
using MediatR.CommandQuery.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AzureNamer.Shared.Models;

// ReSharper disable once CheckNamespace
namespace AzureNamer.Core.Registrations;

public class LocationServiceRegistration
{
    [RegisterServices]
    public void Register(IServiceCollection services)
    {
        #region Generated Register
        services.AddEntityQueries<AzureNamer.Core.Data.AzureNamerContext, AzureNamer.Core.Data.Entities.Location, int, LocationReadModel>();

        services.AddEntityCommands<AzureNamer.Core.Data.AzureNamerContext, AzureNamer.Core.Data.Entities.Location, int, LocationReadModel, LocationCreateModel, LocationUpdateModel>();

        #endregion
    }

}

