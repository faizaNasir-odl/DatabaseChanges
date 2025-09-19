using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConfigrationVersioningHistory
{
    public int ConfigId { get; set; }

    public double? VersionNum { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? CreatedDate { get; set; }

    public int? CustomerIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public DateTime? VersionStartDate { get; set; }

    public DateTime? VersionEndDate { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
