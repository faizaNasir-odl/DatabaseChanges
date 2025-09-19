using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmPriority
{
    public int AlarmPriorityId { get; set; }

    public string? AlarmPriorityTitle { get; set; }

    public string? PriorityType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<AlarmStatesConfig> AlarmStatesConfigs { get; set; } = new List<AlarmStatesConfig>();

    public virtual ICollection<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; } = new List<DataAlarmStatesConfig>();

    public virtual ICollection<SiteEventsM2m> SiteEventsM2ms { get; set; } = new List<SiteEventsM2m>();
}
