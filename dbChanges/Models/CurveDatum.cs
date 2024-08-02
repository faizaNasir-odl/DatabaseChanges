using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CurveDatum
{
    public int CurveId { get; set; }

    public int? CurveHeaderIdFk { get; set; }

    public decimal? CurveValue { get; set; }

    public int? AssetIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? RowNo { get; set; }
}
