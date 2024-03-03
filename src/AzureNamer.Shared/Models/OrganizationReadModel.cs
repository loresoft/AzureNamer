using System;
using System.Collections.Generic;

namespace AzureNamer.Shared.Models;

public partial class OrganizationReadModel
    : EntityReadModel
{
    #region Generated Properties
    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? Description { get; set; }

    #endregion

}
