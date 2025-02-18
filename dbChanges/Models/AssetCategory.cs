using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetCategory
{
    public int AcId { get; set; }

    public string? AcName { get; set; }

    public int? AtId { get; set; }

    public string? AcDescription { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsKpiconfigurable { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? SystemIntegratorIdFk { get; set; }

    public virtual AssetType? At { get; set; }

    public virtual ICollection<KpiFormula> KpiFormulas { get; } = new List<KpiFormula>();
}
