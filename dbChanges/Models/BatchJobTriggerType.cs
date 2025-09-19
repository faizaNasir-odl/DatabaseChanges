using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobTriggerType
{
    public int Id { get; set; }

    public string TriggerTypeName { get; set; } = null!;

    public virtual ICollection<BatchJobsScheduling> BatchJobsSchedulings { get; set; } = new List<BatchJobsScheduling>();

    public virtual ICollection<BpmjobsScheduling> BpmjobsSchedulings { get; set; } = new List<BpmjobsScheduling>();
}
