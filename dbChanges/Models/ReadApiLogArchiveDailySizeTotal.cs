using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiLogArchiveDailySizeTotal
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? UserId { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? TotalResponseSizeBytes { get; set; }

    public bool? ApxFlag { get; set; }

    public string? AvgResponseSizeBytes { get; set; }

    public string? MaxResponseSizeBytes { get; set; }

    public string? MinResponseSizeBytes { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
