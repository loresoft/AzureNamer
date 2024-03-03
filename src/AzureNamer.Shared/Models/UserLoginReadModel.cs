using System;
using System.Collections.Generic;

using Generator.Equals;

namespace AzureNamer.Shared.Models;

[Equatable]
public partial class UserLoginReadModel
    : EntityReadModel
{
    #region Generated Properties
    public string? UserAgent { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public string? Platform { get; set; }

    public string? Version { get; set; }

    public string? Device { get; set; }

    public string? IpAddress { get; set; }

    public int UserId { get; set; }

    #endregion

}
