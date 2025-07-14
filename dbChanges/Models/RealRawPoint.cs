using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RealRawPoint
{
    public int RealTagId { get; set; }

    public int? AdxId { get; set; }

    public string? RMappedName { get; set; }

    public string? RTagName { get; set; }

    public string? RtUnit { get; set; }

    public bool? IsTTotalizer { get; set; }

    public double? ScanInterval { get; set; }

    public int? TotalizerRefrenceId { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Description { get; set; }

    public int? AssetIdFk { get; set; }

    public bool IsStreamProcessing { get; set; }

    public string? SourceType { get; set; }

    public bool? IsCloudTotalizer { get; set; }

    public int? SourceTagIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public string? DataType { get; set; }

    public string? TagAddress { get; set; }

    public string? FlowRate { get; set; }

    public int? ScanRate { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? SiteSpecificDeviceId { get; set; }

    public int? RMappedByDevice { get; set; }

    public bool? Stdev { get; set; }

    public bool? Variation { get; set; }

    public bool? Roc { get; set; }

    public bool? Average { get; set; }

    public bool? Min { get; set; }

    public bool? Max { get; set; }

    public int? StatisticalRefrenceId { get; set; }

    public int? DataTypeIdFk { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsGps { get; set; }

    public int? ParentId { get; set; }

    public int? Persistence { get; set; }

    public decimal? Deadband { get; set; }

    public bool? IsPersistenceOn { get; set; }

    public bool? IsDeadbandOn { get; set; }

    public virtual ICollection<DataAlarm> DataAlarms { get; } = new List<DataAlarm>();

    public virtual ICollection<DependenciesMetrix> DependenciesMetrixes { get; } = new List<DependenciesMetrix>();

    public virtual ICollection<ProcessAlarm> ProcessAlarms { get; } = new List<ProcessAlarm>();

    public virtual ICollection<RawTagTargetMonYear> RawTagTargetMonYears { get; } = new List<RawTagTargetMonYear>();

    public virtual ICollection<RawTagTarget> RawTagTargets { get; } = new List<RawTagTarget>();

    public virtual ICollection<TagLakeLastUpdate> TagLakeLastUpdates { get; } = new List<TagLakeLastUpdate>();
}
