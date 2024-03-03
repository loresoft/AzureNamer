using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class UserLogin : IHaveIdentifier<int>
{
    public UserLogin()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public string? UserAgent { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Platform { get; set; }

    public string? Version { get; set; }

    public string? Device { get; set; }

    public string? IpAddress { get; set; }

    public int UserId { get; set; }

    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public long RowVersion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual User User { get; set; } = null!;

    #endregion

}
