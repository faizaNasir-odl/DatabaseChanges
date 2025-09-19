using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportJobExecutionLog
{
    public int LogId { get; set; }

    public int JobId { get; set; }

    public DateTime ExecutionTimestamp { get; set; }

    public int? RecordCount { get; set; }

    public string? Duration { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public Guid? ExecutionId { get; set; }

    public string? RunId { get; set; }

    public DateTime? RequestedStartTime { get; set; }

    public DateTime? RequestedEndTime { get; set; }
}
