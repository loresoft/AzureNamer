using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureNamer.Core.Data.Mapping;

public partial class HistoryMap
    : IEntityTypeConfiguration<AzureNamer.Core.Data.Entities.History>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AzureNamer.Core.Data.Entities.History> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("History", "AN");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Name)
            .IsRequired()
            .HasColumnName("Name")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.UserId)
            .IsRequired()
            .HasColumnName("UserId")
            .HasColumnType("int");

        builder.Property(t => t.OrganizationId)
            .HasColumnName("OrganizationId")
            .HasColumnType("int");

        builder.Property(t => t.Created)
            .IsRequired()
            .HasColumnName("Created")
            .HasColumnType("datetimeoffset")
            .HasDefaultValueSql("(sysutcdatetime())");

        builder.Property(t => t.CreatedBy)
            .HasColumnName("CreatedBy")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Updated)
            .IsRequired()
            .HasColumnName("Updated")
            .HasColumnType("datetimeoffset")
            .HasDefaultValueSql("(sysutcdatetime())");

        builder.Property(t => t.UpdatedBy)
            .HasColumnName("UpdatedBy")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.RowVersion)
            .IsRequired()
            .HasConversion<byte[]>()
            .IsRowVersion()
            .IsConcurrencyToken()
            .HasColumnName("RowVersion")
            .HasColumnType("rowversion")
            .ValueGeneratedOnAddOrUpdate();

        // relationships
        builder.HasOne(t => t.Organization)
            .WithMany(t => t.Histories)
            .HasForeignKey(d => d.OrganizationId)
            .HasConstraintName("FK_History_Organization_OrganizationId");

        builder.HasOne(t => t.User)
            .WithMany(t => t.Histories)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("FK_History_User_UserId");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "AN";
        public const string Name = "History";
    }

    public readonly struct Columns
    {
        public const string Id = "Id";
        public const string Name = "Name";
        public const string UserId = "UserId";
        public const string OrganizationId = "OrganizationId";
        public const string Created = "Created";
        public const string CreatedBy = "CreatedBy";
        public const string Updated = "Updated";
        public const string UpdatedBy = "UpdatedBy";
        public const string RowVersion = "RowVersion";
    }
    #endregion
}
