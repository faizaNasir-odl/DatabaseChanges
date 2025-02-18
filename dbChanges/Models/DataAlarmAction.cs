using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataAlarmAction
{
    public int DatId { get; set; }

    public int? DataAlarmIdFk { get; set; }

    public double? CurrentValue { get; set; }

    public int? AstIdFk { get; set; }

    public byte[] ReadingTime { get; set; } = null!;

    public virtual DataAlarmStatesConfig? AstIdFkNavigation { get; set; }

    public virtual DataAlarm? DataAlarmIdFkNavigation { get; set; }
}
