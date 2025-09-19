using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OtLongDatum
{
    public DateTime Timestamp { get; set; }

    public string TagName { get; set; } = null!;

    public double Value { get; set; }

    public string Site { get; set; } = null!;

    public string Unit { get; set; } = null!;
}
