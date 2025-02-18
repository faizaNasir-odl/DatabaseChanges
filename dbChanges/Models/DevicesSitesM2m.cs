using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DevicesSitesM2m
{
    public int Id { get; set; }

    public int? DeviceId { get; set; }

    public int? SiteId { get; set; }

    public int? SiteSpecificId { get; set; }

    public bool? IsActive { get; set; }
}
