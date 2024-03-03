using System;
using System.Collections.Generic;

namespace AzureNamer.Shared.Models;

public partial class UserOrganizationUpdateModel
    : EntityUpdateModel
{
    #region Generated Properties
    public int UserId { get; set; }

    public int OrganizationId { get; set; }

    public bool IsOwner { get; set; }

    #endregion

}
