using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorApiUrl
{
    public int Id { get; set; }

    public string? Url { get; set; }

    public int? SiteId { get; set; }

    public int? TenantId { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedAt { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? UpdatedBy { get; set; }
}
