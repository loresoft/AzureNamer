namespace AzureNamer.Shared.Models;

public record UserMembership(
    bool IsAuthenticated,
    int UserId,
    Guid Identifier,
    string Name,
    string Email,
    bool IsAdministrator,
    IReadOnlyCollection<OrganizationMembership>? Organizations);
