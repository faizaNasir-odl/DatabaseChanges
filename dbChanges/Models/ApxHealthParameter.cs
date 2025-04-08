using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthParameter
{
    public int Id { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Unit { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? Priority { get; set; }

    public int? StepIdFk { get; set; }

    public bool? IsRequired { get; set; }

    public int? MinValue { get; set; }

    public int? MaxValue { get; set; }

    public string? TextType { get; set; }
}
