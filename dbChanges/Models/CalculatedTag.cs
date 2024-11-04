using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CalculatedTag
{
    public int CTagId { get; set; }

    public string? CTagName { get; set; }

    public string? Formula { get; set; }

    public bool? IsTotalizer { get; set; }

    public string? CalculatedMappedName { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? AssetIdFk { get; set; }

    public string? Unit { get; set; }

    public bool? IsStreamProcessing { get; set; }

    public int? SiteIdFk { get; set; }

    public string? MappedFormula { get; set; }

    public bool? Stdev { get; set; }

    public bool? Variation { get; set; }

    public bool? Roc { get; set; }

    public bool? Average { get; set; }

    public bool? Min { get; set; }

    public bool? Max { get; set; }

    public int? StatisticalRefrenceId { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsConditional { get; set; }

    public bool? IsKpitag { get; set; }

    public bool? IsTimerTag { get; set; }

    public bool? IsCounterTag { get; set; }

    public int? TotalizerReferenceId { get; set; }

    public string? FlowRate { get; set; }

    public string? OutputType { get; set; }

    public decimal? Deadband { get; set; }

    public int? Persistence { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }

    public virtual ICollection<ConditionalCalculation> ConditionalCalculations { get; } = new List<ConditionalCalculation>();
}
