using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Export5
{
    public string TagName { get; set; } = null!;

    public short Id { get; set; }

    public DateTime IngestionTime { get; set; }
}
