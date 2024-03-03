using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class Project : IHaveIdentifier<int>
{
    public Project()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? Description { get; set; }

    public int SortOrder { get; set; }

    public int OrganizationId { get; set; }

    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public long RowVersion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Organization Organization { get; set; } = null!;

    #endregion

}
