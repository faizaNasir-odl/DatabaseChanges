using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorPipelineMapping
{
    public int Id { get; set; }

    public string? SourceField { get; set; }

    public string? SourceType { get; set; }

    public string? InterimField { get; set; }

    public string? InterimType { get; set; }

    public string? SinkField { get; set; }

    public string? SinkType { get; set; }

    public int? PipelineId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual EnpConnectorPipeline? Pipeline { get; set; }
}
