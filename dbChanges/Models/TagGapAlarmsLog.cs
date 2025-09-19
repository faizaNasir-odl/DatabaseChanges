using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TagGapAlarmsLog
{
    public int TagGapId { get; set; }

    public int SiteIdFk { get; set; }

    public int TagIdFk { get; set; }

    public string MappedName { get; set; } = null!;

    public decimal DurationMinutes { get; set; }

    public decimal ThresholdMinutes { get; set; }

    public DateTime FiredAt { get; set; }

    public DateTime? ResolvedAt { get; set; }

    public string? State { get; set; }

    public int? TagUpdateIdFk { get; set; }

    public int TagTypeIdFk { get; set; }

    public bool IsActive { get; set; }

    public DateTime? LastNotifiedOn { get; set; }

    public virtual PlantSite SiteIdFkNavigation { get; set; } = null!;

    public virtual RealRawPoint TagIdFkNavigation { get; set; } = null!;

    public virtual TagLakeLastUpdate? TagUpdateIdFkNavigation { get; set; }
}
