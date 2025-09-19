using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OtLongDataPattern
{
    public string TagName { get; set; } = null!;

    public double Value { get; set; }

    public DateTime Timestamp { get; set; }
}
