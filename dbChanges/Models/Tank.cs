using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Tank
{
    public int TankId { get; set; }

    public int? ProdIdFk { get; set; }

    public int? SiteId { get; set; }

    public double? Capacity { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
