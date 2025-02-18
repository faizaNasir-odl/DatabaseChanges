using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RawTagsTargetsHistory
{
    public int? TardetId { get; set; }

    public int? RawTagId { get; set; }

    public double? TargetValue { get; set; }

    public double? TargetMinValue { get; set; }

    public double? TarrgetMaxValue { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? HistoryType { get; set; }

    public string? RawTargetMapped { get; set; }

    public string? RtargetMinMapped { get; set; }

    public string? RtargetMaxMapped { get; set; }

    public int HistoryId { get; set; }

    public string? TargetName { get; set; }

    public string? MinTargetName { get; set; }

    public string? MaxTargetName { get; set; }
}
