using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConfigrationVersioning
{
    public int ConfigId { get; set; }

    public double? VersionNum { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CustomerIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public DateTime? VersionStartDate { get; set; }

    public DateTime? VersionEndDate { get; set; }

    public virtual Customer? CustomerIdFkNavigation { get; set; }
}
