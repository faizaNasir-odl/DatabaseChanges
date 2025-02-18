using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DependenciesMetrix
{
    public int DmId { get; set; }

    public int? CalTagPId { get; set; }

    public int? MfTagIdFk { get; set; }

    public int? CalTagIdFk { get; set; }

    public int? CalTargetIdFk { get; set; }

    public int? RealTagIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? Status { get; set; }

    public int? CalculatedTagTargetId { get; set; }

    public int? CalculatedTagMinTargetId { get; set; }

    public int? CalculatedTagMaxTargetId { get; set; }

    public int? RawTagTargetId { get; set; }

    public int? RawTagMinTargetId { get; set; }

    public int? RawTagMaxTargetId { get; set; }

    public bool? IsActive { get; set; }

    public virtual CalculatedTag? CalTagIdFkNavigation { get; set; }

    public virtual ManualFixPoint? MfTagIdFkNavigation { get; set; }

    public virtual RealRawPoint? RealTagIdFkNavigation { get; set; }
}
