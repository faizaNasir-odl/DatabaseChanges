using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportSiteLayOutStatus
{
    public int SiteLayOutId { get; set; }

    public byte[]? LayOutFile { get; set; }

    public bool? IsExportLayoutInProgress { get; set; }

    public string? UserId { get; set; }

    public int? SiteId { get; set; }

    public bool? IsFileDownloaded { get; set; }

    public virtual PlantSite? Site { get; set; }

    public virtual AspNetUser? User { get; set; }
}
