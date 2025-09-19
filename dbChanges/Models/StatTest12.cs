using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class StatTest12
{
    public string? AlarmTime { get; set; }

    public string? StateTitle { get; set; }

    public string? Status { get; set; }

    public double? TriggeredStateId { get; set; }

    public string? AlarmPriority { get; set; }

    public double? LowerValue { get; set; }

    public double? UpperValue { get; set; }

    public double? Interval { get; set; }

    public string? TagName { get; set; }

    public string? Value { get; set; }
}
