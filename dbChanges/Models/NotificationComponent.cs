using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NotificationComponent
{
    public int ComponentId { get; set; }

    public int? CategoryIdFk { get; set; }

    public string? ComponentName { get; set; }

    public bool? IsActive { get; set; }

    public virtual NotificationCategory? CategoryIdFkNavigation { get; set; }

    public virtual ICollection<NotificationEvent> NotificationEvents { get; set; } = new List<NotificationEvent>();

    public virtual ICollection<SiteComponentConfiguration> SiteComponentConfigurations { get; set; } = new List<SiteComponentConfiguration>();
}
