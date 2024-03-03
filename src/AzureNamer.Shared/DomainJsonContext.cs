using System.Text.Json.Serialization;

using AzureNamer.Shared.Models;

using MediatR.CommandQuery.Queries;

// ReSharper disable once CheckNamespace
namespace AzureNamer.Shared;

[JsonSourceGenerationOptions(DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
#region Generated Attributes
[JsonSerializable(typeof(EnvironmentReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<EnvironmentReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<EnvironmentReadModel>))]
[JsonSerializable(typeof(EnvironmentCreateModel))]
[JsonSerializable(typeof(EnvironmentUpdateModel))]
[JsonSerializable(typeof(HistoryReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<HistoryReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<HistoryReadModel>))]
[JsonSerializable(typeof(HistoryCreateModel))]
[JsonSerializable(typeof(HistoryUpdateModel))]
[JsonSerializable(typeof(InviteReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<InviteReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<InviteReadModel>))]
[JsonSerializable(typeof(InviteCreateModel))]
[JsonSerializable(typeof(InviteUpdateModel))]
[JsonSerializable(typeof(LocationReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<LocationReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<LocationReadModel>))]
[JsonSerializable(typeof(LocationCreateModel))]
[JsonSerializable(typeof(LocationUpdateModel))]
[JsonSerializable(typeof(OrganizationReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<OrganizationReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<OrganizationReadModel>))]
[JsonSerializable(typeof(OrganizationCreateModel))]
[JsonSerializable(typeof(OrganizationUpdateModel))]
[JsonSerializable(typeof(ProjectReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<ProjectReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<ProjectReadModel>))]
[JsonSerializable(typeof(ProjectCreateModel))]
[JsonSerializable(typeof(ProjectUpdateModel))]
[JsonSerializable(typeof(ResourceReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<ResourceReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<ResourceReadModel>))]
[JsonSerializable(typeof(ResourceCreateModel))]
[JsonSerializable(typeof(ResourceUpdateModel))]
[JsonSerializable(typeof(SegmentReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<SegmentReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<SegmentReadModel>))]
[JsonSerializable(typeof(SegmentCreateModel))]
[JsonSerializable(typeof(SegmentUpdateModel))]
[JsonSerializable(typeof(SegmentTypeReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<SegmentTypeReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<SegmentTypeReadModel>))]
[JsonSerializable(typeof(UnitReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<UnitReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<UnitReadModel>))]
[JsonSerializable(typeof(UnitCreateModel))]
[JsonSerializable(typeof(UnitUpdateModel))]
[JsonSerializable(typeof(UserLoginReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<UserLoginReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<UserLoginReadModel>))]
[JsonSerializable(typeof(UserOrganizationReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<UserOrganizationReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<UserOrganizationReadModel>))]
[JsonSerializable(typeof(UserOrganizationCreateModel))]
[JsonSerializable(typeof(UserOrganizationUpdateModel))]
[JsonSerializable(typeof(UserReadModel))]
[JsonSerializable(typeof(IReadOnlyCollection<UserReadModel>))]
[JsonSerializable(typeof(EntityPagedResult<UserReadModel>))]
[JsonSerializable(typeof(UserCreateModel))]
[JsonSerializable(typeof(UserUpdateModel))]
[JsonSerializable(typeof(EntityQuery))]
[JsonSerializable(typeof(EntitySelect))]
#endregion
[JsonSerializable(typeof(LogEventModel))]
[JsonSerializable(typeof(IReadOnlyCollection<LogEventModel>))]
[JsonSerializable(typeof(UserMembership))]
[JsonSerializable(typeof(OrganizationMembership))]
[JsonSerializable(typeof(IReadOnlyCollection<OrganizationMembership>))]
public partial class DomainJsonContext : JsonSerializerContext
{

}
