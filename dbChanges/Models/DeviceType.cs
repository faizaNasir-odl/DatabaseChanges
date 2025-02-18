using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceType
{
    public int DeviceTypeId { get; set; }

    public string? DeviceTypeName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<Device> Devices { get; } = new List<Device>();
}
