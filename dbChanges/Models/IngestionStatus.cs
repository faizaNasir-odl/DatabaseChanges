using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class IngestionStatus
{
    public int Id { get; set; }

    public string? DataRange { get; set; }

    public string? CurrentRange { get; set; }

    public string? Status { get; set; }

    public string? OperationId { get; set; }

    public int? SiteId { get; set; }

    public string? CsvFileName { get; set; }

    public DateTime? CreatedAt { get; set; }
}
