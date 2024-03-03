using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureNamer.Core.Data.Mapping;

public partial class SegmentMap
    : IEntityTypeConfiguration<AzureNamer.Core.Data.Entities.Segment>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AzureNamer.Core.Data.Entities.Segment> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Segment", "AN");

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

        builder.Property(t => t.SortOrder)
            .IsRequired()
            .HasColumnName("SortOrder")
            .HasColumnType("int")
            .HasDefaultValue(0);

        builder.Property(t => t.MinimumCharacters)
            .IsRequired()
            .HasColumnName("MinimumCharacters")
            .HasColumnType("int")
            .HasDefaultValue(1);

        builder.Property(t => t.MaximumCharacters)
            .IsRequired()
            .HasColumnName("MaximumCharacters")
            .HasColumnType("int")
            .HasDefaultValue(5);

        builder.Property(t => t.HasDelimterBefore)
            .IsRequired()
            .HasColumnName("HasDelimterBefore")
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(t => t.HasDelimterAfter)
            .IsRequired()
            .HasColumnName("HasDelimterAfter")
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(t => t.IsOptional)
            .IsRequired()
            .HasColumnName("IsOptional")
            .HasColumnType("bit")
            .HasDefaultValue(false);

        builder.Property(t => t.IsLocked)
            .IsRequired()
            .HasColumnName("IsLocked")
            .HasColumnType("bit")
            .HasDefaultValue(false);

        builder.Property(t => t.IsEnabled)
            .IsRequired()
            .HasColumnName("IsEnabled")
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(t => t.SegmentTypeId)
            .IsRequired()
            .HasColumnName("SegmentTypeId")
            .HasColumnType("int");

        builder.Property(t => t.OrganizationId)
            .IsRequired()
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
            .WithMany(t => t.Segments)
            .HasForeignKey(d => d.OrganizationId)
            .HasConstraintName("FK_Segment_Organization_OrganizationId");

        builder.HasOne(t => t.SegmentType)
            .WithMany(t => t.Segments)
            .HasForeignKey(d => d.SegmentTypeId)
            .HasConstraintName("FK_Segment_SegmentType_SegmentTypeId");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "AN";
        public const string Name = "Segment";
    }

    public readonly struct Columns
    {
        public const string Id = "Id";
        public const string Name = "Name";
        public const string SortOrder = "SortOrder";
        public const string MinimumCharacters = "MinimumCharacters";
        public const string MaximumCharacters = "MaximumCharacters";
        public const string HasDelimterBefore = "HasDelimterBefore";
        public const string HasDelimterAfter = "HasDelimterAfter";
        public const string IsOptional = "IsOptional";
        public const string IsLocked = "IsLocked";
        public const string IsEnabled = "IsEnabled";
        public const string SegmentTypeId = "SegmentTypeId";
        public const string OrganizationId = "OrganizationId";
        public const string Created = "Created";
        public const string CreatedBy = "CreatedBy";
        public const string Updated = "Updated";
        public const string UpdatedBy = "UpdatedBy";
        public const string RowVersion = "RowVersion";
    }
    #endregion
}
