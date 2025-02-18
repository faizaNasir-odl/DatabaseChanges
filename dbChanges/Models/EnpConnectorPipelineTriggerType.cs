using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorPipelineTriggerType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public virtual ICollection<EnpConnectorPipelineTrigger> EnpConnectorPipelineTriggers { get; } = new List<EnpConnectorPipelineTrigger>();
}
