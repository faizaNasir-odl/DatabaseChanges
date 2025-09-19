using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobHistory
{
    public int Id { get; set; }

    public int BatchJobId { get; set; }

    public string JobVersion { get; set; } = null!;

    public string? Name { get; set; }

    public string? Query { get; set; }

    public string? TableName { get; set; }

    public int? SiteId { get; set; }

    public int? TenantId { get; set; }

    public DateTime CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public virtual BatchJobsDefinition BatchJob { get; set; } = null!;
}
