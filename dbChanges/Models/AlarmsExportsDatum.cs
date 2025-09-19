using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmsExportsDatum
{
    public string? AlarmTime { get; set; }

    public string? StateTitle { get; set; }

    public string? Status { get; set; }

    public long? TriggeredStateId { get; set; }

    public string? AlarmPriority { get; set; }

    public string? LowerValue { get; set; }

    public string? UpperValue { get; set; }

    public long? Interval { get; set; }

    public string? TagName { get; set; }

    public string? Value { get; set; }
}
