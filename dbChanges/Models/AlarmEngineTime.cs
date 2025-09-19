using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmEngineTime
{
    public int AetId { get; set; }

    public DateTime? ProcessTime { get; set; }

    public int? SiteId { get; set; }
}
