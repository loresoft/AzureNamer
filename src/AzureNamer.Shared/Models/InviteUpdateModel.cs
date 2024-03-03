using System;
using System.Collections.Generic;

using Generator.Equals;

namespace AzureNamer.Shared.Models;

[Equatable]
public partial class InviteUpdateModel
    : EntityUpdateModel
{
    #region Generated Properties
    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SecurityKey { get; set; } = null!;

    public int OrganizationId { get; set; }

    #endregion

}
