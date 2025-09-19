using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ViewWasteTree
{
    public DateTime? Curr { get; set; }

    public double SmdInputCorrected { get; set; }

    public double? PmdWaste { get; set; }

    public double? SmdWaste { get; set; }

    public double? PmdInputCorrected { get; set; }

    public double? OpeningStockUncorrected { get; set; }

    public double? ClosingStockUncorrected { get; set; }

    public double? PmdOutputUncorrected { get; set; }

    public double? SmdOutputCorrected { get; set; }

    public double? SmdOutputCigWeight { get; set; }

    public double? PmdCentralLoop { get; set; }

    public double? PmdLaminaDust { get; set; }

    public double? PmdStemDust { get; set; }

    public double? PmdKnockouts { get; set; }

    public double? PmdFloorSweep { get; set; }

    public double? SmdDust { get; set; }

    public double? Winnowers { get; set; }

    public double? SmdFloorSweep { get; set; }

    public double? VWay { get; set; }

    public double? PmdWetWaste { get; set; }

    public double? SmdUsableReceived { get; set; }

    public double? SmdCigWaste { get; set; }

    public double SmdSpecLoss { get; set; }
}
