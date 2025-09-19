using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ManualFixPoint
{
    public int MfId { get; set; }

    public string? MfTagName { get; set; }

    public double? Value { get; set; }

    public string? Type { get; set; }

    public string? Unit { get; set; }

    public bool? IsTotalizer { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? AssetIdFk { get; set; }

    public string? MfMappedName { get; set; }

    public int? SiteIdFk { get; set; }

    public bool IsActive { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }

    public virtual ICollection<DependenciesMetrix> DependenciesMetrixes { get; set; } = new List<DependenciesMetrix>();
}
