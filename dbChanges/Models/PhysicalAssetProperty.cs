using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class PhysicalAssetProperty
{
    public int PapId { get; set; }

    public string? PropertyName { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AssetProperty> AssetProperties { get; } = new List<AssetProperty>();
}
