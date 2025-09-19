using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TrendingReport
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public int? SiteIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? ChartIdFk { get; set; }

    public bool? IsActive { get; set; }
}
