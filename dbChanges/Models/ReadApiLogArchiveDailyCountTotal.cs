using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiLogArchiveDailyCountTotal
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? UserId { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? CountOfHits { get; set; }

    public bool? ApxFlag { get; set; }

    public string? AvgHitsPerMinute { get; set; }

    public string? MaxHitsPerMinute { get; set; }

    public string? MinHitsPerMinute { get; set; }

    public DateTime? UpdatedTime { get; set; }
}
