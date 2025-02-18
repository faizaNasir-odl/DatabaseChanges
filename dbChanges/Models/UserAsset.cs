using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserAsset
{
    public int UserAssetId { get; set; }

    public string? UserIdFk { get; set; }

    public int? AssetIdFk { get; set; }
}
