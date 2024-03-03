using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class Resource : IHaveIdentifier<int>
{
    public Resource()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public Guid Identifier { get; set; }

    public string? Name { get; set; }

    public string Namespace { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? ValidationDescription { get; set; }

    public int? MinimumCharacters { get; set; }

    public int? MaximumCharacters { get; set; }

    public bool AllowDelimter { get; set; }

    public string? ValidationExpression { get; set; }

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
