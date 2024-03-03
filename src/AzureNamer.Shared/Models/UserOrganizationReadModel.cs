using System;
using System.Collections.Generic;

namespace AzureNamer.Shared.Models;

public partial class UserOrganizationReadModel
    : EntityReadModel
{
    #region Generated Properties
    public int UserId { get; set; }

    public int OrganizationId { get; set; }

    public bool IsOwner { get; set; }

    #endregion

    public string UserName { get; set; } = null!;

    public string UserEmail { get; set; } = null!;

    public string OrganizationName { get; set; } = null!;

    public string OrganizationAbbreviation { get; set; } = null!;

}
