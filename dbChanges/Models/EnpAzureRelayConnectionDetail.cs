using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpAzureRelayConnectionDetail
{
    public int Id { get; set; }

    public string RelayNamespace { get; set; } = null!;

    public string HybridConnectionName { get; set; } = null!;

    public string KeyName { get; set; } = null!;

    public string KeyValue { get; set; } = null!;

    public string ConnectionString { get; set; } = null!;

    public string HybridConnectionUrl { get; set; } = null!;

    public int TenantId { get; set; }

    public int SiteId { get; set; }
}
