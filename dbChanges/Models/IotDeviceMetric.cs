using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class IotDeviceMetric
{
    public int Id { get; set; }

    public DateTime TimeStamp { get; set; }

    public string DeviceName { get; set; } = null!;

    public string? OsInfo { get; set; }

    public string? IotEdgeDaemonVersion { get; set; }

    public string? DockerDaemonVersion { get; set; }

    public int? NumberOfCpus { get; set; }

    public double? HostUptimeDays { get; set; }

    public double? IotEdgeDaemonUptimeDays { get; set; }

    public double? CurrentCpuUsagePercentage { get; set; }

    public double? CurrentMemoryUsage { get; set; }
}
