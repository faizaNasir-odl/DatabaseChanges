using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ScheduledExportsDatum
{
    public DateTime TimeStamp { get; set; }

    public string TagName { get; set; } = null!;

    public double? Value { get; set; }
}
