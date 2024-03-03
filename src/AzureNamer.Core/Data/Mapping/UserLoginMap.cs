using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace AzureNamer.Core.Data.Mapping;

public partial class UserLoginMap
    : IEntityTypeConfiguration<AzureNamer.Core.Data.Entities.UserLogin>
{
    public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<AzureNamer.Core.Data.Entities.UserLogin> builder)
    {
        #region Generated Configure
        // table
        builder.ToTable("UserLogin", "AN");

        // key
        builder.HasKey(t => t.Id);

        // properties
        builder.Property(t => t.Id)
            .IsRequired()
            .HasColumnName("Id")
            .HasColumnType("int")
            .ValueGeneratedOnAdd();

        builder.Property(t => t.UserAgent)
            .HasColumnName("UserAgent")
            .HasColumnType("nvarchar(4000)")
            .HasMaxLength(4000);

        builder.Property(t => t.Name)
            .HasColumnName("Name")
            .HasColumnType("nvarchar(255)")
            .HasMaxLength(255);

        builder.Property(t => t.Type)
            .HasColumnName("Type")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Platform)
            .HasColumnName("Platform")
            .HasColumnType("nvarchar(100)")
            .HasMaxLength(100);

        builder.Property(t => t.Version)
            .HasColumnName("Version")
            .HasColumnType("nvarchar(255)")
            .HasMaxLength(255);

        builder.Property(t => t.Device)
            .HasColumnName("Device")
            .HasColumnType("nvarchar(255)")
            .HasMaxLength(255);

        builder.Property(t => t.IpAddress)
            .HasColumnName("IpAddress")
            .HasColumnType("nvarchar(255)")
            .HasMaxLength(255);

        builder.Property(t => t.UserId)
            .IsRequired()
            .HasColumnName("UserId")
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
        builder.HasOne(t => t.User)
            .WithMany(t => t.UserLogins)
            .HasForeignKey(d => d.UserId)
            .HasConstraintName("FK_UserLogin_User_UserId");

        #endregion
    }

    #region Generated Constants
    public readonly struct Table
    {
        public const string Schema = "AN";
        public const string Name = "UserLogin";
    }

    public readonly struct Columns
    {
        public const string Id = "Id";
        public const string UserAgent = "UserAgent";
        public const string Name = "Name";
        public const string Type = "Type";
        public const string Platform = "Platform";
        public const string Version = "Version";
        public const string Device = "Device";
        public const string IpAddress = "IpAddress";
        public const string UserId = "UserId";
        public const string Created = "Created";
        public const string CreatedBy = "CreatedBy";
        public const string Updated = "Updated";
        public const string UpdatedBy = "UpdatedBy";
        public const string RowVersion = "RowVersion";
    }
    #endregion
}
