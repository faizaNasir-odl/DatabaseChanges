using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TrendingReportsShared
{
    public int Id { get; set; }

    public string? SharedBy { get; set; }

    public string? SharedTo { get; set; }

    public DateTime? SharedDate { get; set; }

    public int? ReportIdFk { get; set; }
}
