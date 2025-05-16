using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FintechTransaction
{
    public int Id { get; set; }

    public int? SiteId { get; set; }

    public int? SaleId { get; set; }

    public string? EndDate { get; set; }

    public string? EndTime { get; set; }

    public int? PumpId { get; set; }

    public int? HoseId { get; set; }

    public int? GradeId { get; set; }

    public double? Volume { get; set; }

    public double? Money { get; set; }

    public double? Ppu { get; set; }

    public int? Level { get; set; }

    public int? SaleType { get; set; }

    public double? InitialVolume { get; set; }

    public double? FinalVolume { get; set; }

    public string? StartDate { get; set; }

    public string? StartTime { get; set; }

    public double? PresetAmount { get; set; }

    public string? SaleAuth { get; set; }

    public string? Authorizer { get; set; }

    public string? Article { get; set; }

    public int? FcSiteId { get; set; }

    public DateTime? FcStartDateTime { get; set; }

    public DateTime? FcEndDateTime { get; set; }

    public DateTime? Createdon { get; set; }
}
