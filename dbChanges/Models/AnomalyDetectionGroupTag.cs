using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionGroupTag
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int TagId { get; set; }

    public string? TagType { get; set; }

    public bool? IsPredictor { get; set; }

    public bool? IsTarget { get; set; }
}
