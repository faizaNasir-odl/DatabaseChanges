using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmRunningHistory
{
    public int Id { get; set; }

    public DateTime? LastProcessedDate { get; set; }

    public int? SiteId { get; set; }
}
