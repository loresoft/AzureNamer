using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureNamer.Core.Data.Mapping;

public partial class ResourceMap
    : IEntityTypeConfiguration<AzureNamer.Core.Data.Entities.Resource>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AzureNamer.Core.Data.Entities.Resource> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("Resource", "AN");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.Identifier)
            .IsRequired()
            .HasColumnName("Identifier")
            .HasColumnType("uniqueidentifier");

        builder.Property(t => t.Name)
            .HasColumnName("Name")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Namespace)
            .IsRequired()
            .HasColumnName("Namespace")
            .HasColumnType("nvarchar(255)")
            .HasMaxLength(255);

        builder.Property(t => t.Abbreviation)
            .IsRequired()
            .HasColumnName("Abbreviation")
            .HasColumnType("nvarchar(10)")
            .HasMaxLength(10);

        builder.Property(t => t.ValidationDescription)
            .HasColumnName("ValidationDescription")
            .HasColumnType("nvarchar(4000)")
            .HasMaxLength(4000);

        builder.Property(t => t.MinimumCharacters)
            .HasColumnName("MinimumCharacters")
            .HasColumnType("int");

        builder.Property(t => t.MaximumCharacters)
            .HasColumnName("MaximumCharacters")
            .HasColumnType("int");

        builder.Property(t => t.AllowDelimter)
            .IsRequired()
            .HasColumnName("AllowDelimter")
            .HasColumnType("bit")
            .HasDefaultValue(true);

        builder.Property(t => t.ValidationExpression)
            .HasColumnName("ValidationExpression")
            .HasColumnType("nvarchar(2000)")
            .HasMaxLength(2000);

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
            .WithMany(t => t.Resources)
            .HasForeignKey(d => d.OrganizationId)
            .HasConstraintName("FK_Resource_Organization_OrganizationId");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "AN";
        public const string Name = "Resource";
    }

    public readonly struct Columns
    {
        public const string Id = "Id";
        public const string Identifier = "Identifier";
        public const string Name = "Name";
        public const string Namespace = "Namespace";
        public const string Abbreviation = "Abbreviation";
        public const string ValidationDescription = "ValidationDescription";
        public const string MinimumCharacters = "MinimumCharacters";
        public const string MaximumCharacters = "MaximumCharacters";
        public const string AllowDelimter = "AllowDelimter";
        public const string ValidationExpression = "ValidationExpression";
        public const string OrganizationId = "OrganizationId";
        public const string Created = "Created";
        public const string CreatedBy = "CreatedBy";
        public const string Updated = "Updated";
        public const string UpdatedBy = "UpdatedBy";
        public const string RowVersion = "RowVersion";
    }
    #endregion
}
