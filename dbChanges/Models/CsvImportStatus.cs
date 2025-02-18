using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CsvImportStatus
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string ImportBy { get; set; } = null!;

    public DateTime StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string? FileName { get; set; }

    public int SiteId { get; set; }

    public long? TotalBlock { get; set; }

    public int? UploadedBlock { get; set; }

    public long UploadedBytes { get; set; }

    public string? BlockList { get; set; }

    public int LastBlockId { get; set; }

    public string ProgressStatus { get; set; } = null!;

    public int? IsIngested { get; set; }

    public string? IngestedUrl { get; set; }
}
