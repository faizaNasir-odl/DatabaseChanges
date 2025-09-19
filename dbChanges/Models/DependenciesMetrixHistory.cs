using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DependenciesMetrixHistory
{
    public int? DmId { get; set; }

    public int? CalTagPId { get; set; }

    public int? MfTagIdFk { get; set; }

    public int? CalTagIdFk { get; set; }

    public int? CalTargetIdFk { get; set; }

    public int? RealTagIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public int? CalculatedTagTargetId { get; set; }

    public int? CalculatedTagMinTargetId { get; set; }

    public int? CalculatedTagMaxTargetId { get; set; }

    public int? RawTagTargetId { get; set; }

    public int? RawTagMinTargetId { get; set; }

    public int? RawTagMaxTargetId { get; set; }

    public int HistoryId { get; set; }

    public bool? Status { get; set; }
}
