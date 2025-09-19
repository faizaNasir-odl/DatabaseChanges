using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceDlSetting
{
    public int Id { get; set; }

    public string? DlSiteName { get; set; }

    public string? DlUsername { get; set; }

    public string? DlPassword { get; set; }

    public int? DeviceIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SiteIdFk { get; set; }

    public virtual Device? DeviceIdFkNavigation { get; set; }

    public virtual PlantSite? SiteIdFkNavigation { get; set; }
}
