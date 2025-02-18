using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ManualFixPointsHistory
{
    public int MfId { get; set; }

    public string? MfTagName { get; set; }

    public double? Value { get; set; }

    public string? Type { get; set; }

    public string? Unit { get; set; }

    public bool? IsTotalizer { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? AssetIdFk { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
