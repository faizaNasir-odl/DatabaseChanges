using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TobaccoWasteManualEntry
{
    public int Id { get; set; }

    public double? SmdCbPm { get; set; }

    public double? SmdGf { get; set; }

    public double? SmdCl { get; set; }

    public double? SmdAy { get; set; }

    public double? SmdTotal { get; set; }

    public double? PmdCtsOpeningStockNextDay { get; set; }

    public double? PmdOutputActual { get; set; }

    public double? PmdInputActual { get; set; }

    public double? DustQuantitiesCentral { get; set; }

    public double? DustQuantitiesLaminaAirlift { get; set; }

    public double? DustQuantitiesStemAirliftSieves { get; set; }

    public double? DustQuantitiesTotalPmdDust { get; set; }

    public double? DustQuantitiesSmdDust { get; set; }

    public double? KnockoutsCbPmDaily { get; set; }

    public double? KnockoutsCbPmDailyHighestOperation { get; set; }

    public double? KnockoutsGfDaily { get; set; }

    public double? KnockoutsGfDailyHighestOperation { get; set; }

    public double? KnockoutsAverageDaily { get; set; }

    public double? KnockoutsAverageDailyHighestOperation { get; set; }

    public double? KnockoutsTotal { get; set; }

    public double? FloorSweepPmd { get; set; }

    public double? FloorSweepWetScrap { get; set; }

    public double? PmdProduction { get; set; }

    public double? UseableSmdRecovered { get; set; }

    public double? SmdWinnowwers { get; set; }

    public double? CigWtWasteReceivedSmd { get; set; }

    public double? UsableTobaccoSmd { get; set; }

    public double? SmdFloorSweep { get; set; }

    public double? VWayDust { get; set; }

    public DateTime? TimeStamp { get; set; }

    public double? ConstantCbpmOutputCf { get; set; }

    public double? ConstantCbPmCigCf { get; set; }

    public double? ConstantGfOutputCf { get; set; }

    public double? ConstantGfCigCf { get; set; }

    public double? ConstantClOutputCf { get; set; }

    public double? ConstantClCigCf { get; set; }

    public double? ConstantAyOutputCf { get; set; }

    public double? ConstantAyCihCf { get; set; }

    public double? PmdInputCorrected { get; set; }

    public double? OpeningStockUncorrected { get; set; }

    public double? ClosingStockUncorrected { get; set; }

    public double? PmdOutputUncorrected { get; set; }

    public double? SmdInputCorrected { get; set; }

    public double? SmdOutputCorrected { get; set; }

    public double? SmdOutputCigWeight { get; set; }

    public double? PmdWaste { get; set; }

    public double? PmdLaminaDust { get; set; }

    public double? PmdStemDust { get; set; }

    public double? PmdCentralLoop { get; set; }

    public double? PmdKnockouts { get; set; }

    public double? PmdWetWaste { get; set; }

    public double? PmdFloorSweep { get; set; }

    public double? PmdUnaccountable { get; set; }

    public double? SmdWaste { get; set; }

    public double? SmdDust { get; set; }

    public double? Winnowers { get; set; }

    public double? UseableShorts { get; set; }

    public double? FloorSweep { get; set; }

    public double? VWay { get; set; }

    public double? Unaccountable { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public double? CleaningDustNrr { get; set; }

    public double? UseableInSmdDustPsd { get; set; }

    public double? OverallPmddust { get; set; }

    public double? CalcSmddust { get; set; }

    public double? CalcOverallSmddust { get; set; }

    public double? CalcUseableSmd { get; set; }

    public double? CalcSmdUsable { get; set; }

    public double? UseableSmdReceived { get; set; }

    public double? CalcUseableSmdReceived { get; set; }

    public double? CalcSmdFloorsweep { get; set; }

    public double? Specloss { get; set; }
}
