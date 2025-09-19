using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CopyDataAlarmAction
{
    public int DatId { get; set; }

    public string? DataAlarmActionGuid { get; set; }

    public int? DataAlarmId { get; set; }

    public int? AsId { get; set; }

    public double? CurrentValue { get; set; }

    public DateTime? ReadingTime { get; set; }

    public int? StateId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public int? AstId { get; set; }

    public string? ActionPerformedBy { get; set; }

    public int? IsActive { get; set; }
}
