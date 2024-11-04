using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class KpieIpTagsParameter
{
    public int TagVariableId { get; set; }

    public string? VariableName { get; set; }

    public string? VariableDescription { get; set; }

    public string? Unit { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? Priority { get; set; }

    public bool? IsRequired { get; set; }
}
