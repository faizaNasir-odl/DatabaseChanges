using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class QualityManualEntryMoistureContentFilledValue
{
    public int Id { get; set; }

    public string? Shift { get; set; }

    public string? Blend { get; set; }

    public int? SampleNo { get; set; }

    public double? LcMc { get; set; }

    public double? ScMc { get; set; }

    public double? ExDryerMc { get; set; }

    public double? ExDryerDr { get; set; }

    public double? ExDryerFv { get; set; }

    public double? ExCpsSiloMc { get; set; }

    public double? ExCpsSiloDr { get; set; }

    public double? ExCpsSiloFv { get; set; }

    public double? FpSilosMc { get; set; }

    public double? FpSilosDr { get; set; }

    public double? FpSilosFv { get; set; }

    public double? FeederMc { get; set; }

    public double? FeederDr { get; set; }

    public double? FeederFv { get; set; }

    public double? MakerMc { get; set; }

    public double? MakerDr { get; set; }

    public double? MakerFv { get; set; }

    public DateTime? Date { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public int? OperationNo { get; set; }
}
