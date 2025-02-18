using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionTagResult
{
    public int Id { get; set; }

    public int GroupResultId { get; set; }

    public int TagId { get; set; }

    public string TagType { get; set; } = null!;

    public DateTime? TimeStamp { get; set; }

    public bool? Anomaly { get; set; }

    public bool? PersistenceAnomaly { get; set; }

    public double? PersistenceRatio { get; set; }

    public double? Actual { get; set; }

    public double? Predicted { get; set; }

    public double? UpperLimit { get; set; }

    public double? LowerLimit { get; set; }

    public bool? Notify { get; set; }

    public double? ExplainedVariance { get; set; }

    public double? Mse { get; set; }

    public double? Rmse { get; set; }

    public double? R2 { get; set; }
}
