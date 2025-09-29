using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorPipeline
{
    public int Id { get; set; }

    public string DatabaseName { get; set; } = null!;

    public string TableName { get; set; } = null!;

    public int WriteBehaviourId { get; set; }

    public int WriteOptionId { get; set; }

    public string? UniqueKeyName { get; set; }

    public string? Query { get; set; }

    public bool IsAutoMapping { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int ConnectorId { get; set; }

    public string? PipelineName { get; set; }

    public string? Jsonpath { get; set; }

    public string? Jsonresult { get; set; }

    public virtual EnpConnectorConnector Connector { get; set; } = null!;

    public virtual ICollection<EnpConnectorPipelineMapping> EnpConnectorPipelineMappings { get; set; } = new List<EnpConnectorPipelineMapping>();

    public virtual ICollection<EnpConnectorPipelineTrigger> EnpConnectorPipelineTriggers { get; set; } = new List<EnpConnectorPipelineTrigger>();

    public virtual EnpConnectorPipelineWriteBehaviour WriteBehaviour { get; set; } = null!;

    public virtual EnpConnectorPipelineWriteOption WriteOption { get; set; } = null!;
}
