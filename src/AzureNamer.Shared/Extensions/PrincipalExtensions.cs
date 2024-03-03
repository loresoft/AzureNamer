using System.Security.Claims;
using System.Security.Principal;

namespace AzureNamer.Shared.Extensions;

public static class PrincipalExtensions
{
    public const string ObjectIdenttifier = "oid";

    public const string Subject = "sub";
    public const string NameClaim = "name";
    public const string EmailClaim = "email";
    public const string EmailsClaim = "emails";
    public const string ProviderClaim = "idp";
    public const string UserIdClaim = "uid";
    public const string OrgainizationClaim = "org";

    private const string IdentityClaim = "http://schemas.microsoft.com/identity/claims/identityprovider";
    private const string IdentifierClaim = "http://schemas.microsoft.com/identity/claims/objectidentifier";
    private const string UpnClaim = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/upn";

    public static string? GetEmail(this IPrincipal principal)
    {
        if (principal is null)
            throw new ArgumentNullException(nameof(principal));

        var claimPrincipal = principal as ClaimsPrincipal;
        var claim = claimPrincipal?.FindFirst(ClaimTypes.Email)
            ?? claimPrincipal?.FindFirst(EmailClaim)
            ?? claimPrincipal?.FindFirst(EmailsClaim)
            ?? claimPrincipal?.FindFirst(UpnClaim);

        return claim?.Value;
    }

    public static Guid? GetObjectId(this IPrincipal principal)
    {
        if (principal is null)
            throw new ArgumentNullException(nameof(principal));

        var claimPrincipal = principal as ClaimsPrincipal;
        var claim = claimPrincipal?.FindFirst(IdentifierClaim)
            ?? claimPrincipal?.FindFirst(ObjectIdenttifier)
            ?? claimPrincipal?.FindFirst(ClaimTypes.NameIdentifier);

        return Guid.TryParse(claim?.Value, out var oid) ? oid : null;
    }

    public static int? GetUserId(this IPrincipal principal)
    {
        if (principal is null)
            throw new ArgumentNullException(nameof(principal));

        var claimPrincipal = principal as ClaimsPrincipal;
        var claim = claimPrincipal?.FindFirst(UserIdClaim);

        return int.TryParse(claim?.Value, out var uid) ? uid : null;
    }

    public static string? GetName(this IPrincipal principal)
    {
        if (principal is null)
            throw new ArgumentNullException(nameof(principal));

        var claimPrincipal = principal as ClaimsPrincipal;
        var claim = claimPrincipal?.FindFirst(NameClaim)
            ?? claimPrincipal?.FindFirst(ClaimTypes.Name);

        return claim?.Value;
    }

    public static string? GetProvider(this IPrincipal principal)
    {
        if (principal is null)
            throw new ArgumentNullException(nameof(principal));

        var claimPrincipal = principal as ClaimsPrincipal;
        var claim = claimPrincipal?.FindFirst(ProviderClaim)
            ?? claimPrincipal?.FindFirst(IdentityClaim);

        return claim?.Value;
    }

}
