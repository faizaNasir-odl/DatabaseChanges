using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteApiLog
{
    public int Id { get; set; }

    public DateTime Timestamp { get; set; }

    public string? UserName { get; set; }

    public string? SiteName { get; set; }

    public string? CustomerName { get; set; }

    public int? ResponseStatusCode { get; set; }

    public int? ResponseTimeMs { get; set; }

    public int? Records { get; set; }

    public string? Message { get; set; }

    public string? TagType { get; set; }

    public string? ItemNamesRequest { get; set; }

    public string? ResponseSizeBytes { get; set; }
}
