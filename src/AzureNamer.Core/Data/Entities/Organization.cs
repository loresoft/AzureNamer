using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class Organization : IHaveIdentifier<int>
{
    public Organization()
    {
        #region Generated Constructor
        Environments = new HashSet<Environment>();
        Histories = new HashSet<History>();
        Invites = new HashSet<Invite>();
        Locations = new HashSet<Location>();
        Projects = new HashSet<Project>();
        Resources = new HashSet<Resource>();
        Segments = new HashSet<Segment>();
        Units = new HashSet<Unit>();
        UserOrganizations = new HashSet<UserOrganization>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? Description { get; set; }

    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public long RowVersion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<Environment> Environments { get; set; }

    public virtual ICollection<History> Histories { get; set; }

    public virtual ICollection<Invite> Invites { get; set; }

    public virtual ICollection<Location> Locations { get; set; }

    public virtual ICollection<Project> Projects { get; set; }

    public virtual ICollection<Resource> Resources { get; set; }

    public virtual ICollection<Segment> Segments { get; set; }

    public virtual ICollection<Unit> Units { get; set; }

    public virtual ICollection<UserOrganization> UserOrganizations { get; set; }

    #endregion

}
