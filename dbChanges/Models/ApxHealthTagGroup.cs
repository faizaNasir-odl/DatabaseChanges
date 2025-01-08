using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthTagGroup
{
    public int Id { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? GroupIds { get; set; }

    public string? FormulaCondition { get; set; }

    public string? Formula { get; set; }

    public int? ParameterIdFk { get; set; }

    public int? Priority { get; set; }

    public int? StepIdFk { get; set; }

    public bool? IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
