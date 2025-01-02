using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxParameterCategory
{
    public int Id { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? Section { get; set; }

    public string? Category { get; set; }

    public string? InsightType { get; set; }

    public int? Priority { get; set; }

    public string? StepName { get; set; }
}
