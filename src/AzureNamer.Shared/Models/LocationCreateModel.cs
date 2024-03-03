using System;
using System.Collections.Generic;

using Generator.Equals;

namespace AzureNamer.Shared.Models;

[Equatable]
public partial class LocationCreateModel
    : EntityCreateModel
{
    #region Generated Properties
    public Guid Identifier { get; set; }

    public string Name { get; set; } = null!;

    public string Abbreviation { get; set; } = null!;

    public string? Description { get; set; }

    public int OrganizationId { get; set; }

    #endregion

}
