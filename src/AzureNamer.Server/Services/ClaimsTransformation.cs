using System.Security.Claims;
using System.Text.Json;

using AzureNamer.Core.Commands;
using AzureNamer.Shared;
using AzureNamer.Shared.Constants;

using Blazone.Authentication.Options;

using MediatR;

using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Options;

namespace AzureNamer.Server.Services;

[RegisterScoped<IClaimsTransformation>(Duplicate = DuplicateStrategy.Append)]
public class ClaimsTransformation : IClaimsTransformation
{
    private readonly IMediator _mediator;
    private readonly ILogger<ClaimsTransformation> _logger;
    private readonly IMemoryCache _memoryCache;
    private readonly AuthenticationEndpointOptions _endpointOptions;

    public ClaimsTransformation(IMediator mediator, ILogger<ClaimsTransformation> logger, IOptions<AuthenticationEndpointOptions> endpointOptions, IMemoryCache memoryCache)
    {
        _mediator = mediator;
        _logger = logger;
        _endpointOptions = endpointOptions.Value;
        _memoryCache = memoryCache;
    }

    public async Task<ClaimsPrincipal> TransformAsync(ClaimsPrincipal principal)
    {
        var name = principal.Identity?.Name ?? "unknown";
        var key = $"AzureNamer:User:{name}";

        var result = await _memoryCache.GetOrCreateAsync(key, cacheEntry => LoadClaims(cacheEntry, principal));

        return result ?? principal;

    }

    private async Task<ClaimsPrincipal> LoadClaims(ICacheEntry cacheEntry, ClaimsPrincipal principal)
    {
        var command = new AuthorizationCommand(principal);
        var userMembership = await _mediator.Send(command);

        if (userMembership == null)
            return principal;

        var clone = principal.Clone();
        var identity = clone.Identity as ClaimsIdentity;
        if (identity == null)
            return principal;

        // set cache timeout
        cacheEntry.SlidingExpiration = _endpointOptions.UserCacheTime;

        // use saved name and email
        ReplaceClaim(identity, identity.NameClaimType, userMembership.Name);
        ReplaceClaim(identity, ClaimTypes.Email, userMembership.Email);

        // include user id
        identity.AddClaim(new Claim(Claims.UserId, userMembership.UserId.ToString()));

        // add role
        if (userMembership.IsAdministrator)
            identity.AddClaim(new Claim(identity.RoleClaimType, Roles.Administrators));

        if (userMembership.Organizations == null)
            return clone;

        // include organizations via json
        var json = JsonSerializer.Serialize(userMembership.Organizations, DomainJsonContext.Default.IReadOnlyCollectionOrganizationMembership);
        identity.AddClaim(new Claim(Claims.Organizations, json));

        return clone;
    }

    private void ReplaceClaim(ClaimsIdentity identity, string type, string value)
    {
        var claim = identity.FindFirst(type);
        if (claim != null)
        {
            if (claim.Value == value)
                return;

            identity.RemoveClaim(claim);
        }

        var newClaim = new Claim(type, value);
        identity.AddClaim(newClaim);
    }
}
