using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EventCategory
{
    public int EcategoryId { get; set; }

    public string? CategoryName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<EventComponent> EventComponents { get; } = new List<EventComponent>();
}
