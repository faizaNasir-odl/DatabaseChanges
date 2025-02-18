using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RawTagTarget
{
    public int RawTagTergetId { get; set; }

    public double? TargetValue { get; set; }

    public double? TargetMinValue { get; set; }

    public double? TargetMaxValue { get; set; }

    public int? RealTagIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? RawTargetMapped { get; set; }

    public string? RtargetMinMapped { get; set; }

    public string? RtargetMaxMapped { get; set; }

    public string? TargetName { get; set; }

    public string? MinTargetName { get; set; }

    public string? MaxTargetName { get; set; }

    public bool? IsActive { get; set; }

    public virtual RealRawPoint? RealTagIdFkNavigation { get; set; }
}
