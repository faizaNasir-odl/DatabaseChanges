using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobTriggerType
{
    public int Id { get; set; }

    public string TriggerTypeName { get; set; } = null!;

    public virtual ICollection<BatchJobsScheduling> BatchJobsSchedulings { get; } = new List<BatchJobsScheduling>();
}
