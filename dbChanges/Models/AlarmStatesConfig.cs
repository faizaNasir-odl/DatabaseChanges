using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmStatesConfig
{
    public int AstId { get; set; }

    public int? StateId { get; set; }

    public int? ProcessAlarmId { get; set; }

    public int? AlarmPriorityId { get; set; }

    public double? Value { get; set; }

    public bool? IsNotificationAllow { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public virtual AlarmPriority? AlarmPriority { get; set; }

    public virtual ICollection<AlarmRecipientM2m> AlarmRecipientM2ms { get; } = new List<AlarmRecipientM2m>();

    public virtual ProcessAlarm? ProcessAlarm { get; set; }

    public virtual AlarmState? State { get; set; }
}
