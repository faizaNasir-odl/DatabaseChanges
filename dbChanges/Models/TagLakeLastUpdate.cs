using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TagLakeLastUpdate
{
    public int TagUpdateId { get; set; }

    public int SiteIdFk { get; set; }

    public int? TagId { get; set; }

    public DateTime? IngestionTime { get; set; }

    public DateTime? CheckTime { get; set; }

    public int? DeviceIdFk { get; set; }

    public string MappedName { get; set; } = null!;

    public long? ThresholdMinutes { get; set; }

    public DateTime? IngestTimeUpdatedAt { get; set; }

    public int TagTypeIdFk { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ReleaseEnv { get; set; }

    public DateTime TableEntryOn { get; set; }

    public virtual Device? DeviceIdFkNavigation { get; set; }

    public virtual PlantSite SiteIdFkNavigation { get; set; } = null!;

    public virtual ICollection<TagGapAlarmsLog> TagGapAlarmsLogs { get; set; } = new List<TagGapAlarmsLog>();
}
