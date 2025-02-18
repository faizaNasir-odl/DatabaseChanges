using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Nozzel
{
    public int Id { get; set; }

    public int? NozzelId { get; set; }

    public int? PumpId { get; set; }

    public int? TankId { get; set; }

    public int? SiteId { get; set; }
}
