using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionGroupResult
{
    public int Id { get; set; }

    public int? GroupId { get; set; }

    public DateTime? TimeStamp { get; set; }

    public int? TotalTags { get; set; }

    public int? AnomalousTags { get; set; }

    public string? Status { get; set; }
}
