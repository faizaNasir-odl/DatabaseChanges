using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TblTankStatus
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public double? Capacity { get; set; }

    public double? Consumption { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }
}
