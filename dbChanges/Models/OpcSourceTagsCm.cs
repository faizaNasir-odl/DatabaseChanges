using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcSourceTagsCm
{
    public int EventId { get; set; }

    public int? SiteSpecificEventId { get; set; }

    public int? SourceTagIdFk { get; set; }

    public string? SourceTagName { get; set; }

    public int? SiteIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public string? TagAddress { get; set; }

    public int? OnPremSourceTagId { get; set; }

    public string? Unit { get; set; }

    public int? ScanRate { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? SiteSpecificDeviceId { get; set; }

    public string? EntryType { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? EventLog { get; set; }

    public virtual Device? SiteSpecificDevice { get; set; }

    public virtual OpcSourceTag? SourceTagIdFkNavigation { get; set; }
}
