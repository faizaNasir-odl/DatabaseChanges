using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class QualityManualEntryFibexDatum
{
    public int Id { get; set; }

    public string? Opno { get; set; }

    public int? Op { get; set; }

    public int? CaseNo { get; set; }

    public double? Mc { get; set; }

    public double? Dr { get; set; }

    public double? Fv { get; set; }

    public DateTime? Date { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
