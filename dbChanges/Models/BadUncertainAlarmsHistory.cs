using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BadUncertainAlarmsHistory
{
    public int? SiteId { get; set; }

    public string? ReadingTime { get; set; }

    public int Id { get; set; }
}
