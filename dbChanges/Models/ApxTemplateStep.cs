using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxTemplateStep
{
    public int Id { get; set; }

    public string? StepName { get; set; }

    public int? Priority { get; set; }

    public bool? IsRequired { get; set; }

    public string? InsightType { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsOutputMapping { get; set; }
}
