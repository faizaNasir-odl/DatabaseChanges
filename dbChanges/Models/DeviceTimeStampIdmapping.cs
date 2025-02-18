using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceTimeStampIdmapping
{
    public int Id { get; set; }

    public int? DeviceId { get; set; }

    public int? TimeStampSourceTagIdFk { get; set; }

    public int? IdSourceTagIdFk { get; set; }

    public string? TimeStampFormat { get; set; }

    public virtual Device? Device { get; set; }

    public virtual OpcSourceTag? IdSourceTagIdFkNavigation { get; set; }

    public virtual OpcSourceTag? TimeStampSourceTagIdFkNavigation { get; set; }
}
