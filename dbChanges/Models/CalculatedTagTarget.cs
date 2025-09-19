using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CalculatedTagTarget
{
    public int TagTargetId { get; set; }

    public int? CTagIdFk { get; set; }

    public double? TargetValue { get; set; }

    public double? MaximumTarget { get; set; }

    public double? MinimumTarget { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CalculatedTargetMapped { get; set; }

    public string? CalculatedTargetMinMapped { get; set; }

    public string? CalculatedTargetMaxMapped { get; set; }

    public string? TargetName { get; set; }

    public string? MinTargetName { get; set; }

    public string? MaxTargetName { get; set; }

    public bool IsActive { get; set; }

    public virtual CalculatedTag? CTagIdFkNavigation { get; set; }
}
