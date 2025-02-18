using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EdgeDevice
{
    public int EdId { get; set; }

    public string? CpuUtilization { get; set; }

    public string? HardDiskSize { get; set; }

    public string? HardDiskConsumption { get; set; }

    public string? HardDiskFreeSpace { get; set; }

    public string? MemoryUsage { get; set; }

    public DateTime? LastSignalReceived { get; set; }

    public string? BufferedDataSize { get; set; }

    public int? SiteIdFk { get; set; }

    public string? EdgeDeviceId { get; set; }
}
