using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetLibraryHistory
{
    public int AssetLibId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public byte[]? AssetImage { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
