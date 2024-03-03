using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class Segment : IHaveIdentifier<int>
{
    public Segment()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int SortOrder { get; set; }

    public int MinimumCharacters { get; set; }

    public int MaximumCharacters { get; set; }

    public bool HasDelimterBefore { get; set; }

    public bool HasDelimterAfter { get; set; }

    public bool IsOptional { get; set; }

    public bool IsLocked { get; set; }

    public bool IsEnabled { get; set; }

    public int SegmentTypeId { get; set; }

    public int OrganizationId { get; set; }

    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public long RowVersion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Organization Organization { get; set; } = null!;

    public virtual SegmentType SegmentType { get; set; } = null!;

    #endregion

}
