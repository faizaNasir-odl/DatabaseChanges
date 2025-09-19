using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceOpcServerM2m
{
    public int Id { get; set; }

    public int? OpcIdFk { get; set; }

    public int? DeviceIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public virtual Device? DeviceIdFkNavigation { get; set; }

    public virtual OpcServerConfig? OpcIdFkNavigation { get; set; }
}
