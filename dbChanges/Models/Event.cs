using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Event
{
    public int EventId { get; set; }

    public int? EcomponentId { get; set; }

    public string? EventName { get; set; }

    public bool? IsActive { get; set; }

    public virtual EventComponent? Ecomponent { get; set; }

    public virtual ICollection<SiteEventsM2m> SiteEventsM2ms { get; } = new List<SiteEventsM2m>();
}
