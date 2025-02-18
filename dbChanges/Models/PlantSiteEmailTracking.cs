using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class PlantSiteEmailTracking
{
    public int Id { get; set; }

    public int? SiteIdFk { get; set; }

    public bool? EmailSent { get; set; }

    public bool? IsSiteCreated { get; set; }
}
