using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TestScanRateTable
{
    public int Id { get; set; }

    public int? SiteIdFk { get; set; }

    public string? RMappedName { get; set; }

    public string? SourceTagName { get; set; }

    public string? RTagName { get; set; }

    public string? DataType { get; set; }

    public int? RMappedByDevice { get; set; }

    public int? DeviceTypeIdFk { get; set; }

    public int? SiteSpecificDeviceId { get; set; }

    public int? RealTagId { get; set; }

    public int? AdxId { get; set; }

    public bool? IsTTotalizer { get; set; }

    public double? ScanInterval { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? ScanRate { get; set; }

    public int? TotalizerRefrenceId { get; set; }

    public bool? IsGps { get; set; }

    public int? SourceTagId { get; set; }
}
