using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class HamexecutionLog
{
    public long LogId { get; set; }

    public int SourceId { get; set; }

    public DateTime ExecutionTime { get; set; }

    public string TriggerType { get; set; } = null!;

    public long? RecordsIngested { get; set; }

    public string Status { get; set; } = null!;

    public string? ErrorMessage { get; set; }

    public virtual HamdataSource Source { get; set; } = null!;
}
