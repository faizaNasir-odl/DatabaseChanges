using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmStatusAction
{
    public int AsId { get; set; }

    public string? AsTitle { get; set; }

    public virtual ICollection<DataAlarmAction> DataAlarmActions { get; } = new List<DataAlarmAction>();

    public virtual ICollection<SystemAlarmAction> SystemAlarmActions { get; } = new List<SystemAlarmAction>();
}
