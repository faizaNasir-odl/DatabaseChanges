using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConditionalCalculation
{
    public int Id { get; set; }

    public int? CalTagIdFk { get; set; }

    public int? ConditionSequence { get; set; }

    public string? ConditionFormula { get; set; }

    public string? ConditionMappedFormula { get; set; }

    public string? TrueFormula { get; set; }

    public string? TrueMappedFormula { get; set; }

    public string? FalseFormula { get; set; }

    public string? FalseMappedFormula { get; set; }

    public int? ParentConditionId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? StopConditionFormula { get; set; }

    public string? StopConditionMappedFormula { get; set; }

    public virtual CalculatedTag? CalTagIdFkNavigation { get; set; }
}
