using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AdfPipelineConfig
{
    public int JobId { get; set; }

    public string SubscriptionId { get; set; } = null!;

    public string RgName { get; set; } = null!;

    public string DfName { get; set; } = null!;

    public string PipelineName { get; set; } = null!;

    public string? RestBaseUrl { get; set; }

    public string? RestRelativeUrl { get; set; }

    public string? RestJsonPath { get; set; }

    public string? AdxClusterUri { get; set; }

    public string? AdxDatabase { get; set; }

    public string? AdxTable { get; set; }

    public string TenantId { get; set; } = null!;

    public string SpClientId { get; set; } = null!;

    public string SpClientSecret { get; set; } = null!;

    public string? ColumnMapping { get; set; }

    public DateTime? CreatedAt { get; set; }
}
