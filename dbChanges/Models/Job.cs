using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Job
{
    public Guid JobId { get; set; }

    public bool IsCancelled { get; set; }

    public DateTime InitialInsertTimeUtc { get; set; }

    public int JobType { get; set; }

    public string? InputData { get; set; }

    public int TaskCount { get; set; }

    public int CompletedTaskCount { get; set; }

    public Guid? TracingId { get; set; }

    public virtual ICollection<MessageQueue> MessageQueues { get; } = new List<MessageQueue>();
}
