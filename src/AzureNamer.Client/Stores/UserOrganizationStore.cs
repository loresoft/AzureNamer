using System;
using System.Reflection;

using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Extensions;
using AzureNamer.Shared.Models;

using MediatR.CommandQuery.Queries;

using Microsoft.AspNetCore.Components.Authorization;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class UserOrganizationStore : StateBase<IReadOnlyCollection<UserOrganizationReadModel>>
{
    public UserOrganizationStore(
        ILoggerFactory loggerFactory,
        UserOrganizationRepository repository,
        AuthenticationStateProvider authenticationStateProvider)
    {
        Logger = loggerFactory.CreateLogger(GetType());
        Repository = repository;
        AuthenticationStateProvider = authenticationStateProvider;
    }

    public ILogger Logger { get; }

    public UserOrganizationRepository Repository { get; }

    public AuthenticationStateProvider AuthenticationStateProvider { get; }

    public bool IsBusy { get; protected set; }

    public int? UserId { get; protected set; }

    public async Task LoadCurrent()
    {
        var authenticationState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var userId = authenticationState.User.GetUserId();
        if (userId == null || (UserId.HasValue && UserId == userId && Model != null))
            return;

        try
        {
            IsBusy = true;

            // create filter
            var filter = new EntityFilter
            {
                Name = nameof(UserOrganizationReadModel.UserId),
                Value = userId,
                Operator = EntityFilterOperators.Equal
            };
            var sort = new EntitySort
            {
                Name = nameof(UserOrganizationReadModel.OrganizationName),
                Direction = "Asc"
            };
            var entitySelect = new EntitySelect(filter, sort);

            // set model
            Model = await Repository.Select(entitySelect);

            // save user id
            UserId = userId;
        }
        finally
        {
            IsBusy = false;
            NotifyStateChanged();
        }
    }
}
