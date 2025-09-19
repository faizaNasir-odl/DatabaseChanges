using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadApiLogArchiveMinLimitBreach
{
    public int Id { get; set; }

    public DateTime? Minute { get; set; }

    public string? UserId { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? CountOfHits { get; set; }

    public bool? ApxFlag { get; set; }
}
