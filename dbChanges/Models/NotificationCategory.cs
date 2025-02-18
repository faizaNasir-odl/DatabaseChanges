using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NotificationCategory
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<NotificationComponent> NotificationComponents { get; } = new List<NotificationComponent>();
}
