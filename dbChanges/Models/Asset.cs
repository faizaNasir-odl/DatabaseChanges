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

    public virtual ICollection<AssetAssetAreaMToM> AssetAssetAreaMToMs { get; } = new List<AssetAssetAreaMToM>();

    public virtual ICollection<AssetProperty> AssetProperties { get; } = new List<AssetProperty>();

    public virtual ICollection<CalculatedTag> CalculatedTags { get; } = new List<CalculatedTag>();

    public virtual ICollection<ManualFixPoint> ManualFixPoints { get; } = new List<ManualFixPoint>();

    public virtual ICollection<TblTankStatus> TblTankStatuses { get; } = new List<TblTankStatus>();

    public virtual ICollection<TblTransaction> TblTransactions { get; } = new List<TblTransaction>();

    public virtual ICollection<WhatIfResult> WhatIfResults { get; } = new List<WhatIfResult>();
}
