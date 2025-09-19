using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RestApicolumnMapping
{
    public int JobId { get; set; }

    public string OriginalColumn { get; set; } = null!;

    public string? MappedColumn { get; set; }

    public string? DataType { get; set; }
}
