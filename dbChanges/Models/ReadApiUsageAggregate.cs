using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiUsageAggregate
{
    public int Id { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? TotalDataRead { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public int? SiteIdFk { get; set; }
}
