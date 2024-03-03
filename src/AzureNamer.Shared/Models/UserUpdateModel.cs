using System;
using System.Collections.Generic;

using Generator.Equals;

namespace AzureNamer.Shared.Models;

[Equatable]
public partial class UserUpdateModel
    : EntityUpdateModel
{
    #region Generated Properties
    public Guid Identifier { get; set; }

    public string Name { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Provider { get; set; }

    public bool IsAdministrator { get; set; }

    #endregion

}
