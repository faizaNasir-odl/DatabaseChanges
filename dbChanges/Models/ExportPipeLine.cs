using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportPipeLine
{
    public int PipeLineId { get; set; }

    public string? PipeLineName { get; set; }

    public int? SiteId { get; set; }

    public string? UserId { get; set; }

    public string? ConnectionHostName { get; set; }

    public string? DatabaseName { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public string? SelectedTagType { get; set; }

    public string? TransferType { get; set; }

    public string? ScheduleTransferResoultionType { get; set; }

    public int? ScheduleTrasferResolutionValue { get; set; }

    public DateTime? ScheduleStartDate { get; set; }

    public DateTime? ManualDataTransferStartDate { get; set; }

    public DateTime? ManualDataTrnsferEndtDate { get; set; }

    public string? DataPointResolutionValueType { get; set; }

    public int? DataPointResolutionValue { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<PipeLineTag> PipeLineTags { get; } = new List<PipeLineTag>();
}
