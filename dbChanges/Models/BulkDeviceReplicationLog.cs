using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BulkDeviceReplicationLog
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public string DeviceNameConvention { get; set; } = null!;

    public int DeviceCount { get; set; }

    public string DeviceType { get; set; } = null!;

    public int TemplateDeviceId { get; set; }

    public string TagnameConvention { get; set; } = null!;

    public string? Description { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string Status { get; set; } = null!;

    public virtual ICollection<BulkDeviceReplicationLogDevice> BulkDeviceReplicationLogDevices { get; set; } = new List<BulkDeviceReplicationLogDevice>();
}
