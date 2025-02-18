using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDatum
{
    public DateTime TimeStamp { get; set; }

    public string TagName { get; set; } = null!;

    public double? Actual { get; set; }

    public bool IsAnomaly { get; set; }

    public bool PersistentAnomaly { get; set; }

    public double? PersistenceRatio { get; set; }

    public string? TagGroup { get; set; }

    public string? Site { get; set; }

    public double? Predicted { get; set; }

    public double? LowerLimit { get; set; }

    public double? UpperLimit { get; set; }
}
