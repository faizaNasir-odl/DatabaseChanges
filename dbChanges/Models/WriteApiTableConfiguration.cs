using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteApiTableConfiguration
{
    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public int? DeviceId { get; set; }

    public string? TableType { get; set; }

    public string? Consumergroup { get; set; }

    public string? ConnectionString { get; set; }

    public string? IotHubName { get; set; }

    public string? DbType { get; set; }

    public string? DbName { get; set; }

    public string? TableName { get; set; }

    public string? DataConnectionName { get; set; }

    public int CustomerId { get; set; }
}
