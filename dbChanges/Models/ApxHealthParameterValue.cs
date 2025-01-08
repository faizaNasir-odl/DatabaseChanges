using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthParameterValue
{
    public int? AssetIdFk { get; set; }

    public int? ParameterIdFk { get; set; }

    public int? TagId { get; set; }

    public string? TagType { get; set; }

    public string? TagDescription { get; set; }

    public string? ConstValue { get; set; }

    public int? MinValue { get; set; }

    public int? MaxValue { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int Id { get; set; }
}
