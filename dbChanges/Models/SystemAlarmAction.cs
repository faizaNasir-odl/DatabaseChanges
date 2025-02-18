using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SystemAlarmAction
{
    public int SaaId { get; set; }

    public int? SiteEventId { get; set; }

    public DateTime? ReadingTime { get; set; }

    public int? AsId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public string? SystemAlarmDescription { get; set; }

    public string? ActionPerformedBy { get; set; }

    public string? ActivityPerformedBy { get; set; }

    public bool? IsActive { get; set; }

    public virtual AspNetUser? ActionPerformedByNavigation { get; set; }

    public virtual AlarmStatusAction? As { get; set; }

    public virtual SiteEventsM2m? SiteEvent { get; set; }
}
