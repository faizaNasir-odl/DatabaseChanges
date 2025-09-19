using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SchPullExecutionLog3
{
    public int LogId { get; set; }

    public int PipelineId { get; set; }

    public string? PipelineName { get; set; }

    public DateTime ExecutionTimestamp { get; set; }

    public string? Triggeredby { get; set; }

    public int? Triggerid { get; set; }

    public string? Triggername { get; set; }

    public string? Triggerstatus { get; set; }

    public DateTime? Triggertime { get; set; }

    public int? Duration { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public int? ConnectorId { get; set; }

    public string? OutputLink { get; set; }
}
