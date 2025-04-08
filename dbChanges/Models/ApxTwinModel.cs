using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxTwinModel
{
    public int? AssetIdFk { get; set; }

    public int? ModelCount { get; set; }

    public int? PoorCount { get; set; }

    public int? MarginalCount { get; set; }

    public int? GoodCount { get; set; }

    public string? ResultJson { get; set; }

    public bool? IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int Id { get; set; }

    public bool? IsModelActivating { get; set; }
}
