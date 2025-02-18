using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Schedule
{
    public int ScheduleId { get; set; }

    public int FreqType { get; set; }

    public int FreqInterval { get; set; }

    public virtual ICollection<ScheduleTask1> ScheduleTask1s { get; } = new List<ScheduleTask1>();
}
