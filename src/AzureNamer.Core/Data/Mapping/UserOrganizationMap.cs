using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureNamer.Core.Data.Mapping;

public partial class UserOrganizationMap
    : IEntityTypeConfiguration<AzureNamer.Core.Data.Entities.UserOrganization>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AzureNamer.Core.Data.Entities.UserOrganization> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("UserOrganization", "AN");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.UserId)
            .IsRequired()
            .HasColumnName("UserId")
            .HasColumnType("int");

        builder.Property(t => t.OrganizationId)
            .IsRequired()
            .HasColumnName("OrganizationId")
            .HasColumnType("int");

        builder.Property(t => t.IsOwner)
            .IsRequired()
            .HasColumnName("IsOwner")
            .HasColumnType("bit")
            .HasDefaultValue(false);

        // relationships
        builder.HasOne(t => t.Organization)
            .WithMany(t => t.UserOrganizations)
            .HasForeignKey(d => d.OrganizationId)
            .HasConstraintName("FK_UserOrganization_Organization_OrganizationId");

        builder.HasOne(t => t.User)
            .WithMany(t => t.UserOrganizations)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("FK_UserOrganization_User_UserId");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "AN";
        public const string Name = "UserOrganization";
    }

    public readonly struct Columns
    {
        public const string Id = "Id";
        public const string UserId = "UserId";
        public const string OrganizationId = "OrganizationId";
        public const string IsOwner = "IsOwner";
    }
    #endregion
}
