using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class User : IHaveIdentifier<int>
{
    public User()
    {
        #region Generated Constructor
        Histories = new HashSet<History>();
        UserLogins = new HashSet<UserLogin>();
        UserOrganizations = new HashSet<UserOrganization>();
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public Guid Identifier { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Provider { get; set; }

    public bool IsAdministrator { get; set; }

    public DateTimeOffset Created { get; set; }

    public string? CreatedBy { get; set; }

    public DateTimeOffset Updated { get; set; }

    public string? UpdatedBy { get; set; }

    public long RowVersion { get; set; }

    #endregion

    #region Generated Relationships
    public virtual ICollection<History> Histories { get; set; }

    public virtual ICollection<UserLogin> UserLogins { get; set; }

    public virtual ICollection<UserOrganization> UserOrganizations { get; set; }

    #endregion

}
