using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CurveHeader
{
    public int CurveHeaderId { get; set; }

    public string? CurveHeaderName { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public string? Unit { get; set; }

    public double? MinValue { get; set; }

    public double? MaxValue { get; set; }
}
