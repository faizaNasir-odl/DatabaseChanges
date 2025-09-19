using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AllAlarmFinal1
{
    public string? AlarmTime { get; set; }

    public string? StateTitle { get; set; }

    public string? Status { get; set; }

    public double? TriggeredStateId { get; set; }

    public string? AlarmPriority { get; set; }

    public string? LowerValue { get; set; }

    public string? UpperValue { get; set; }

    public string? TagName { get; set; }

    public string? Value { get; set; }
}
