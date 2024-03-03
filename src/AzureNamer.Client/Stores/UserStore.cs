using AutoMapper;

using AzureNamer.Client.Repositories;
using AzureNamer.Shared.Extensions;
using AzureNamer.Shared.Models;

using Microsoft.AspNetCore.Components.Authorization;

namespace AzureNamer.Client.Stores;

[RegisterScoped]
public class UserStore : StoreEditBase<UserRepository, int, UserReadModel, UserReadModel, UserUpdateModel>
{
    private readonly AuthenticationStateProvider _authenticationStateProvider;

    public UserStore(ILoggerFactory loggerFactory, UserRepository repository, IMapper mapper, AuthenticationStateProvider authenticationStateProvider) : base(loggerFactory, repository, mapper)
    {
        _authenticationStateProvider = authenticationStateProvider;
    }

    public int? UserId => Original?.Id;

    public async Task LoadCurrent()
    {
        var authenticationState = await _authenticationStateProvider.GetAuthenticationStateAsync();
        var userId = authenticationState.User.GetUserId();
        if (userId == null)
            return;

        await Load(userId.Value);
    }
}
