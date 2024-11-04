using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class LogEvent
{
    public int Id { get; set; }

    public string? EventName { get; set; }

    public string? EventDescription { get; set; }
}
