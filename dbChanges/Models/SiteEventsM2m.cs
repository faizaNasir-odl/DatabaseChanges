using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SiteEventsM2m
{
    public int SiteEventId { get; set; }

    public int SiteId { get; set; }

    public int? EventId { get; set; }

    public bool? IsAlarmActive { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? AsId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public int? AlarmPriorityId { get; set; }

    public bool? IsRequired { get; set; }

    public virtual AlarmPriority? AlarmPriority { get; set; }

    public virtual Event? Event { get; set; }

    public virtual ICollection<SystemAlarmAction> SystemAlarmActions { get; set; } = new List<SystemAlarmAction>();
}
