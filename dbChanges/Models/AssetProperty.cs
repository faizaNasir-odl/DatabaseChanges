using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetProperty
{
    public int ApId { get; set; }

    public string? PapValue { get; set; }

    public int? AssetIdFk { get; set; }

    public int? PapIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }

    public virtual PhysicalAssetProperty? PapIdFkNavigation { get; set; }
}
