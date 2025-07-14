using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TagLakeLastUpdate
{
    public int TagUpdateId { get; set; }

    public int SiteIdFk { get; set; }

    public int? RealTagIdFk { get; set; }

    public DateTime? IngestionTime { get; set; }

    public DateTime? CheckTime { get; set; }

    public int? DeviceIdFk { get; set; }

    public string RMappedName { get; set; } = null!;

    public virtual Device? DeviceIdFkNavigation { get; set; }

    public virtual RealRawPoint? RealTagIdFkNavigation { get; set; }

    public virtual PlantSite SiteIdFkNavigation { get; set; } = null!;
}
