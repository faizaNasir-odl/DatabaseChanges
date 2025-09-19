using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ScheduledPullExecutionLog
{
    public int LogId { get; set; }

    public int TriggerId { get; set; }

    public string TriggerName { get; set; } = null!;

    public int JobId { get; set; }

    public string Status { get; set; } = null!;

    public DateTime? ExecutedAt { get; set; }
}
