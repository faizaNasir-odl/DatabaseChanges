using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionGroup
{
    public int Id { get; set; }

    public int? SiteId { get; set; }

    public string? GroupName { get; set; }

    public string? Description { get; set; }

    public int? GroupLeaderTagId { get; set; }

    public string? GroupLeaderTagType { get; set; }

    public double? MinThreshold { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsRunning { get; set; }

    public bool? IsActive { get; set; }

    public int? ModelTrainingType { get; set; }
}
