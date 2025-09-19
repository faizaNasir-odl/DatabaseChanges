using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Pump
{
    public int Id { get; set; }

    public int? SiteId { get; set; }

    public int? Pumpid { get; set; }

    public int? Tankid { get; set; }
}
