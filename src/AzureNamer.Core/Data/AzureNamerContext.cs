using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AzureNamer.Core.Data;

public partial class AzureNamerContext : DbContext
{
    public AzureNamerContext(DbContextOptions<AzureNamerContext> options)
        : base(options)
    {
    }

    #region Generated Properties
    public virtual DbSet<AzureNamer.Core.Data.Entities.Environment> Environments { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.History> Histories { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Invite> Invites { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Location> Locations { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Organization> Organizations { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Project> Projects { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Resource> Resources { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Segment> Segments { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.SegmentType> SegmentTypes { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.Unit> Units { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.UserLogin> UserLogins { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.UserOrganization> UserOrganizations { get; set; } = null!;

    public virtual DbSet<AzureNamer.Core.Data.Entities.User> Users { get; set; } = null!;

    #endregion

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        #region Generated Configuration
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.EnvironmentMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.HistoryMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.InviteMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.LocationMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.OrganizationMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.ProjectMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.ResourceMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.SegmentMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.SegmentTypeMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.UnitMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.UserLoginMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.UserMap());
        modelBuilder.ApplyConfiguration(new AzureNamer.Core.Data.Mapping.UserOrganizationMap());
        #endregion
    }
}
