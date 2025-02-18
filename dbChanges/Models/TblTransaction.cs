using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TblTransaction
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public string? Article { get; set; }

    public double? Volume { get; set; }

    public double? UnitPrice { get; set; }

    public int? Amount { get; set; }

    public int? Payment { get; set; }

    public string? GasStation { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }
}
