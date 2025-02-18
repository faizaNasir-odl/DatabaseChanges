using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CalculatedTagsHistory
{
    public int CTagId { get; set; }

    public string? CTagName { get; set; }

    public string? Formula { get; set; }

    public string? IsTotalizer { get; set; }

    public string? CalculatedMappedId { get; set; }

    public string? Description { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? AssetIdFk { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;

    public int? SiteIdFk { get; set; }
}
