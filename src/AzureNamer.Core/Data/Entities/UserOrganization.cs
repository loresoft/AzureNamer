using System;
using System.Collections.Generic;

using MediatR.CommandQuery.Definitions;

namespace AzureNamer.Core.Data.Entities;

public partial class UserOrganization : IHaveIdentifier<int>
{
    public UserOrganization()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    public int Id { get; set; }

    public int UserId { get; set; }

    public int OrganizationId { get; set; }

    public bool IsOwner { get; set; }

    #endregion

    #region Generated Relationships
    public virtual Organization Organization { get; set; } = null!;

    public virtual User User { get; set; } = null!;

    #endregion

}
