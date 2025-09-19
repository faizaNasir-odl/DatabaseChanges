using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class QualityManualEntryNtw
{
    public int Id { get; set; }

    public int? WeekNo { get; set; }

    public int? SampleNo { get; set; }

    public DateTime? TimeSelection { get; set; }

    public string? Shift { get; set; }

    public string? Module { get; set; }

    public string? Brand { get; set; }

    public double? CigWt { get; set; }

    public double? Ntc { get; set; }

    public double? Ntw { get; set; }

    public double? TargetNtw { get; set; }

    public double? SpecLoss { get; set; }

    public DateTime? Date { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
