using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportToExcelStatus
{
    public int Id { get; set; }

    public Guid StoredQueryId { get; set; }

    public string UserId { get; set; } = null!;

    public int SiteId { get; set; }

    public bool IsComplete { get; set; }

    public DateTime ExportedDate { get; set; }

    public string OperationId { get; set; } = null!;
}
