using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RawTagTargetMonYearHistory
{
    public int Id { get; set; }

    public double? Year { get; set; }

    public double? January { get; set; }

    public double? February { get; set; }

    public double? March { get; set; }

    public double? April { get; set; }

    public double? May { get; set; }

    public double? June { get; set; }

    public double? July { get; set; }

    public double? August { get; set; }

    public double? September { get; set; }

    public double? October { get; set; }

    public double? November { get; set; }

    public double? December { get; set; }

    public int? RealTagIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
