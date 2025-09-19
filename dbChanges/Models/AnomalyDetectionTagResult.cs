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

    public double? MapeM1 { get; set; }

    public double? MaeM1 { get; set; }

    public double? RsqM1 { get; set; }

    public double? R2ScoreM1 { get; set; }

    public double? R2ScoreM2 { get; set; }

    public double? RsqM2 { get; set; }

    public double? MaeM2 { get; set; }

    public double? MapeM2 { get; set; }

    public double? StabilityScore { get; set; }

    public bool? NbCheck { get; set; }

    public bool? RampCheck { get; set; }

    public double? RampPercentage { get; set; }

    public double? StdError { get; set; }

    public string? Predictors { get; set; }

    public bool? IsOperating { get; set; }
}
