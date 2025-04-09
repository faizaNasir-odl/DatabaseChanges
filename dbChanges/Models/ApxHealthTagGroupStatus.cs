using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthTagGroupStatus
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public int? ApxHealthGroupIdFk { get; set; }

    public string? Status { get; set; }

    public bool? IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsOperating { get; set; }

    public DateTime? OperatingTime { get; set; }
}
