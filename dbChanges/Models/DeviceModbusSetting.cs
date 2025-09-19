using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceModbusSetting
{
    public int Id { get; set; }

    public int DeviceIdFk { get; set; }

    public string Method { get; set; } = null!;

    public string? Port { get; set; }

    public int BaudRate { get; set; }

    public string Parity { get; set; } = null!;

    public int Timeout { get; set; }

    public int? PollingRate { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StopBit { get; set; }

    public virtual Device DeviceIdFkNavigation { get; set; } = null!;
}
