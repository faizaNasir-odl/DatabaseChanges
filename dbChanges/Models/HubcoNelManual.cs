using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class HubcoNelManual
{
    public DateTime Date { get; set; }

    public double? FuelStockHfoTank1 { get; set; }

    public double? FuelStockHfoTank2 { get; set; }

    public double? FuelStockHfoTank3 { get; set; }

    public double? CapacityFactor { get; set; }

    public double? Availability { get; set; }

    public double? InhouseConsumption { get; set; }

    public double? ImportEnergy { get; set; }

    public double? SolarGeneration { get; set; }
}
