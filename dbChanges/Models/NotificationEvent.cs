using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NotificationEvent
{
    public int EventId { get; set; }

    public int? ComponentIdFk { get; set; }

    public string? EventName { get; set; }

    public bool? IsActive { get; set; }

    public virtual NotificationComponent? ComponentIdFkNavigation { get; set; }

    public virtual ICollection<NotificationEventsConfigM2m> NotificationEventsConfigM2ms { get; } = new List<NotificationEventsConfigM2m>();
}
