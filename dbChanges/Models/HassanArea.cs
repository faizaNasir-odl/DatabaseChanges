using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class HassanArea
{
    public long? Id { get; set; }

    public string? AreaName { get; set; }

    public long? CustomerSiteId { get; set; }
}
