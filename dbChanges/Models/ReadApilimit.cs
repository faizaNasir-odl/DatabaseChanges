using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApilimit
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string SiteName { get; set; } = null!;

    public long MaxPerDayLimit { get; set; }

    public int MaxCallsPerMin { get; set; }

    public int UserAccessLevel { get; set; }
}
