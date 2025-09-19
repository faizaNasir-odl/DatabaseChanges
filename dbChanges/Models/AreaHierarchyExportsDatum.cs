using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AreaHierarchyExportsDatum
{
    public string? Area { get; set; }

    public string? ParentAsset { get; set; }

    public string? Asset { get; set; }

    public string? AssetType { get; set; }

    public string? TagType { get; set; }

    public string? TagName { get; set; }
}
