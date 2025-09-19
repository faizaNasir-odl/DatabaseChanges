using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TrendingReportTag
{
    public int Id { get; set; }

    public int? TagIdFk { get; set; }

    public int? TagTypeIdFk { get; set; }

    public int? ReportIdFk { get; set; }
}
