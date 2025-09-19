using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Mtd
{
    public int SiteId { get; set; }

    public double? TotalVol { get; set; }

    public double? TotalPrice { get; set; }

    public double? TotalVolPercentChg { get; set; }

    public double? TotalPriceChg { get; set; }

    public double? Goron92Vol { get; set; }

    public double? Goron92Price { get; set; }

    public double? Goron92VolPercentChg { get; set; }

    public double? Goron92PricePercentChg { get; set; }

    public double? Goron97Vol { get; set; }

    public double? Goron97Price { get; set; }

    public double? Goron97VolPercentChg { get; set; }

    public double? Goron97PricePercentChg { get; set; }

    public double? DieselVol { get; set; }

    public double? DieselPrice { get; set; }

    public double? DieselVolPercentChg { get; set; }

    public double? DieselPricePercentChg { get; set; }

    public DateTime? CreatedOn { get; set; }
}
