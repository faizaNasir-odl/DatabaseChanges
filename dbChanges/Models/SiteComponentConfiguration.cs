using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SiteComponentConfiguration
{
    public int SiteOpeId { get; set; }

    public int? ComponentIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsEmailActive { get; set; }

    public bool? IsSmsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual NotificationComponent? ComponentIdFkNavigation { get; set; }
}
