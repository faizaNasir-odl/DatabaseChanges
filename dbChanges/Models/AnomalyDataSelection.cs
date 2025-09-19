using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDataSelection
{
    public int Id { get; set; }

    public string? Timestamp { get; set; }

    public int? GroupId { get; set; }
}
