using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EventComponent
{
    public int EcomponentId { get; set; }

    public int? EcategoryId { get; set; }

    public string? ComponentName { get; set; }

    public bool? IsActive { get; set; }

    public virtual EventCategory? Ecategory { get; set; }

    public virtual ICollection<Event> Events { get; } = new List<Event>();
}
