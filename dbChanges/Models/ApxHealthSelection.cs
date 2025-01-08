using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthSelection
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public int? StepIdFk { get; set; }

    public bool? HasSpike { get; set; }

    public bool? HasMode { get; set; }

    public string? TimeSlot { get; set; }

    public bool? IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }
}
