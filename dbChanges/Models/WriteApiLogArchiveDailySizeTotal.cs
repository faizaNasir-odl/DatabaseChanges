using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteApiLogArchiveDailySizeTotal
{
    public int Id { get; set; }

    public DateOnly? Date { get; set; }

    public string? UserName { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public string? ResponseSizeBytes { get; set; }
}
