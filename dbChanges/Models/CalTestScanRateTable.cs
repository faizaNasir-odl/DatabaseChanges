using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CalTestScanRateTable
{
    public int Id { get; set; }

    public int? SiteIdFk { get; set; }

    public int? CTagId { get; set; }

    public string? CalculatedMappedName { get; set; }

    public string? CTagName { get; set; }

    public string? TagType { get; set; }

    public int? AdxId { get; set; }

    public bool? IsTotalizer { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? ScanRate { get; set; }

    public double? ScanInterval { get; set; }

    public int? TotalizerReferenceId { get; set; }

    public string? DataTypeName { get; set; }

    public bool? IsCounterTag { get; set; }

    public bool? IsTimerTag { get; set; }

    public string? OutputType { get; set; }

    public bool? IsKpitag { get; set; }

    public int? Rn { get; set; }
}
