using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SystemAlarmActionHistory
{
    public int Id { get; set; }

    public int? SaaId { get; set; }

    public int? StateEventId { get; set; }

    public int? AsId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
