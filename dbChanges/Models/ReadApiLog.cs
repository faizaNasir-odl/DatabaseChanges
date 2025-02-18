using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiLog
{
    public int LogId { get; set; }

    public DateTime? Timestamp { get; set; }

    public string? UserId { get; set; }

    public string? UserName { get; set; }

    public string? SiteName { get; set; }

    public string? CustomerName { get; set; }

    public int? ResponseStatusCode { get; set; }

    public int? ResponseTimeMs { get; set; }

    public string? ResponseSizeBytes { get; set; }

    public string? DataFrameShape { get; set; }

    public int? DataFrameSize { get; set; }

    public string? ItemNamesRequest { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public string? TagType { get; set; }
}
