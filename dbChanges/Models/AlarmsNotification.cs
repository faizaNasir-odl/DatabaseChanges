using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmsNotification
{
    public int AnId { get; set; }

    public int? ProcessAlarmId { get; set; }

    public int? StateId { get; set; }

    public double? CurrentValue { get; set; }

    public DateTime? ReadingTime { get; set; }

    public virtual ProcessAlarm? ProcessAlarm { get; set; }
}
