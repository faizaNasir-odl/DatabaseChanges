using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataAlarmStatesConfig
{
    public int AstId { get; set; }

    public int? StateId { get; set; }

    public int? DataAlarmId { get; set; }

    public int? AlarmPriorityId { get; set; }

    public string? Value { get; set; }

    public double? LowerValue { get; set; }

    public double? UpperValue { get; set; }

    public bool? IsAlarmOn { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? AsId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public int? AlarmProcessed { get; set; }

    public bool? IsCurrentStateActive { get; set; }

    public bool? IsActive { get; set; }

    public int? AlarmDuration { get; set; }

    public virtual AlarmPriority? AlarmPriority { get; set; }

    public virtual DataAlarm? DataAlarm { get; set; }

    public virtual ICollection<DataAlarmAction> DataAlarmActions { get; } = new List<DataAlarmAction>();

    public virtual DataAlarmState? State { get; set; }
}
