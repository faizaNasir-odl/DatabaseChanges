using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Asset
{
    public int AssetId { get; set; }

    public string? AssetName { get; set; }

    public string? Type { get; set; }

    public int? AssetParentId { get; set; }

    public DateTime? LastServiceDate { get; set; }

    public string? LastServiceBy { get; set; }

    public double? HealthStatus { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? SiteIdFk { get; set; }

    public string? AssetType { get; set; }

    public string? AssetCategory { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsKpiactivated { get; set; }

    public bool? IsApxHealthActivated { get; set; }

    public bool? IsApxHealthActivating { get; set; }

    public bool? IsKpiactivating { get; set; }

    public string? ApxHealthStatus { get; set; }

    public string? ApxPerformanceStatus { get; set; }

    public virtual ICollection<CalculatedTag> CalculatedTags { get; } = new List<CalculatedTag>();
}
