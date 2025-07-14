using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportZamil
{
    public string RMappedName { get; set; } = null!;

    public short Id { get; set; }

    public DateTime IngestionTime { get; set; }

    public short SiteIdFk { get; set; }
}
