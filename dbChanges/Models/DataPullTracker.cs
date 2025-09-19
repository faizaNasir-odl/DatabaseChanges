using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataPullTracker
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = null!;

    public string SiteName { get; set; } = null!;

    public DateTime LastTimestamp { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? PipelineId { get; set; }
}
