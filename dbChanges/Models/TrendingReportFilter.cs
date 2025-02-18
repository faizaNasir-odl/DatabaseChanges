using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TrendingReportFilter
{
    public int Id { get; set; }

    public DateTime? StartTime { get; set; }

    public DateTime? EndTime { get; set; }

    public string? Granularity { get; set; }

    public bool? IsLocalTime { get; set; }

    public int? ReportIdFk { get; set; }
}
