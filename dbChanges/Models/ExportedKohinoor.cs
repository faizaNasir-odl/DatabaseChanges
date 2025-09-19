using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportedKohinoor
{
    public string RMappedName { get; set; } = null!;

    public DateTime IngestionTime { get; set; }

    public short SiteIdFk { get; set; }
}
