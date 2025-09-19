using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmjobsScheduling
{
    public int TriggerId { get; set; }

    public string TriggerName { get; set; } = null!;

    public int JobId { get; set; }

    public string ScheduleType { get; set; } = null!;

    public int? ScheduleValue { get; set; }

    public bool LastDayOfMonth { get; set; }

    public int? Hour { get; set; }

    public int? Minute { get; set; }

    public int? Interval { get; set; }

    public bool ExecuteNow { get; set; }

    public bool IsEnabled { get; set; }

    public DateTime? NextDue { get; set; }

    public DateTime? StartedOn { get; set; }

    public DateTime? LastRun { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int TriggerType { get; set; }

    public string? Description { get; set; }

    public int SiteId { get; set; }

    public int TenantId { get; set; }

    public virtual ICollection<BpmjobExecutionLog> BpmjobExecutionLogs { get; set; } = new List<BpmjobExecutionLog>();

    public virtual BpmJob Job { get; set; } = null!;

    public virtual BatchJobTriggerType TriggerTypeNavigation { get; set; } = null!;
}
