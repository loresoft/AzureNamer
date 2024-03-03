using System;
using System.Collections.Generic;

using Generator.Equals;

namespace AzureNamer.Shared.Models;

[Equatable]
public partial class HistoryReadModel
    : EntityReadModel
{
    #region Generated Properties
    public string Name { get; set; } = null!;

    public int UserId { get; set; }

    public int? OrganizationId { get; set; }

    #endregion

}
