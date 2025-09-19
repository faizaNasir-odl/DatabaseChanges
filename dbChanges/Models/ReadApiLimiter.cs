using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiLimiter
{
    public int Id { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? RawSizeMin { get; set; }

    public string? RawSizeMax { get; set; }

    public string? RawSizeAvg { get; set; }

    public string? BoolSizeMin { get; set; }

    public string? BoolSizeMax { get; set; }

    public string? BoolSizeAvg { get; set; }

    public string? TimeSizeMin { get; set; }

    public string? TimeSizeMax { get; set; }

    public string? TimeSizeAvg { get; set; }

    public string? StringSizeMin { get; set; }

    public string? StringSizeMax { get; set; }

    public string? StringSizeAvg { get; set; }

    public string? TotalizerSizeMin { get; set; }

    public string? TotalizerSizeMax { get; set; }

    public string? TotalizerSizeAvg { get; set; }

    public string? CounterSizeMin { get; set; }

    public string? CounterSizeMax { get; set; }

    public string? CounterSizeAvg { get; set; }

    public string? CalcSizeMin { get; set; }

    public string? CalcSizeMax { get; set; }

    public string? CalcSizeAvg { get; set; }

    public string? TimerSizeMin { get; set; }

    public string? TimerSizeMax { get; set; }

    public string? TimerSizeAvg { get; set; }

    public string? IngestionVolMin { get; set; }

    public string? IngestionVolMax { get; set; }

    public string? IngestionVolAvg { get; set; }

    public DateTime? UpdatedTime { get; set; }

    public string? AutomationTableName { get; set; }

    public string? GpsSizeMin { get; set; }

    public string? GpsSizeMax { get; set; }

    public string? GpsSizeAvg { get; set; }

    public string? ManSizeMin { get; set; }

    public string? ManSizeMax { get; set; }

    public string? ManSizeAvg { get; set; }

    public int? SiteIdFk { get; set; }

    public string? MaxResponseSize { get; set; }

    public int? PerMinuteHits { get; set; }

    public DateTime? LimitsModifiedDate { get; set; }

    public string? LimitsModifiedBy { get; set; }

    public string? DailyLimitBytes { get; set; }

    public bool? IsDailyLimitUpdated { get; set; }

    public int? DailyLimitFactor { get; set; }

    public int? MaxDailyLimitFactor { get; set; }
}
