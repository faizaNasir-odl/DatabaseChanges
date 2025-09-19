using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class QualityManualNtwConstantValue
{
    public int Id { get; set; }

    public double? TargetCbpm { get; set; }

    public double? TargetGf { get; set; }

    public double? TargetCl { get; set; }

    public double? TargetAy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
