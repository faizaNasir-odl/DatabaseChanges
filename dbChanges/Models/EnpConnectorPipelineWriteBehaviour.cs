using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorPipelineWriteBehaviour
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EnpConnectorPipeline> EnpConnectorPipelines { get; set; } = new List<EnpConnectorPipeline>();
}
