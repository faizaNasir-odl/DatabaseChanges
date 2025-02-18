using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SiteOpcDefaultSetting
{
    public int Id { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? ScanRate { get; set; }

    public int? DeviceId { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
