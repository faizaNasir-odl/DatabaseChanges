using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AdxIngestionConfig
{
    public int ConfigId { get; set; }

    public string SourceTableName { get; set; } = null!;

    public string SelectedColumns { get; set; } = null!;

    public bool IsLongFormat { get; set; }

    public string? SiteName { get; set; }
}
