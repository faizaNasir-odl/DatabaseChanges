using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorConnector
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public int? Type { get; set; }

    public bool? SelfHostedIr { get; set; }

    public string? DatabaseName { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ServerAddress { get; set; }

    public string? PortNumber { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? TenantId { get; set; }

    public string? SiteId { get; set; }

    public bool IsOtdata { get; set; }

    public virtual ICollection<EnpConnectorPipelineTrigger> EnpConnectorPipelineTriggers { get; set; } = new List<EnpConnectorPipelineTrigger>();

    public virtual ICollection<EnpConnectorPipeline> EnpConnectorPipelines { get; set; } = new List<EnpConnectorPipeline>();

    public virtual EnpConnectorConnectorType? TypeNavigation { get; set; }
}
