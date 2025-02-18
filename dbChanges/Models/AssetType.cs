using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetType
{
    public int AtId { get; set; }

    public string? AtName { get; set; }

    public string? AtDescription { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? SystemIntegratorIdFk { get; set; }

    public virtual ICollection<AssetCategory> AssetCategories { get; } = new List<AssetCategory>();
}
