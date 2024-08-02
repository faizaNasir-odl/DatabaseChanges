using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OutputTagParameter
{
    public int OutputParameterId { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterDescription { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? Unit { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
