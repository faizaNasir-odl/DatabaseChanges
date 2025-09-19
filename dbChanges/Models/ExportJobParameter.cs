using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportJobParameter
{
    public int ParamId { get; set; }

    public int JobId { get; set; }

    public int? SiteId { get; set; }

    public string Mode { get; set; } = null!;

    public string CustomerName { get; set; } = null!;

    public string? SiteName { get; set; }

    public string? AreaName { get; set; }

    public string ItemNames { get; set; } = null!;

    public string? TagType { get; set; }

    public string? TagGranularity { get; set; }

    public bool IsRelativeTime { get; set; }

    public DateTime? StartDatetime { get; set; }

    public DateTime? EndDatetime { get; set; }

    public string? StartRelativeExpr { get; set; }

    public string? EndRelativeExpr { get; set; }

    public string? TagAggregate { get; set; }

    public string? RequiredColumns { get; set; }

    public string? ColumnOrderedBy { get; set; }

    public int? NumberOfLatestRecords { get; set; }

    public bool? UtcTime { get; set; }

    public bool? UserFriendly { get; set; }

    public bool? ProductionDatabase { get; set; }

    public bool? Apx { get; set; }

    public string TargetTable { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public Guid? UserId { get; set; }

    public DateTime? ColumnDatetime { get; set; }
}
