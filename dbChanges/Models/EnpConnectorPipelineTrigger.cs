using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorPipelineTrigger
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int TypeId { get; set; }

    public DateTime StartDateTime { get; set; }

    public DateTime? EndDateTime { get; set; }

    public string? Recurrence { get; set; }

    public int PipelineId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreateDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? ConnectorId { get; set; }

    public DateTime? LastRun { get; set; }

    public string? ScheduleType { get; set; }

    public DateTime? NextDue { get; set; }

    public bool? IsEnabled { get; set; }

    public virtual EnpConnectorConnector? Connector { get; set; }

    public virtual EnpConnectorPipeline Pipeline { get; set; } = null!;

    public virtual EnpConnectorPipelineTriggerType Type { get; set; } = null!;
}
