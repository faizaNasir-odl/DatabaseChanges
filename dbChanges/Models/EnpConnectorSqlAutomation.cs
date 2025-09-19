using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorSqlAutomation
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public int? TenantId { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? SqlServerName { get; set; }

    public string? SqlDbName { get; set; }
}
