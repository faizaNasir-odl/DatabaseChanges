using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetAssetAreaMToM
{
    public int Id { get; set; }

    public int AssetIdFk { get; set; }

    public int AreaIdFk { get; set; }

    public bool? IsActive { get; set; }

    public virtual Asset AssetIdFkNavigation { get; set; } = null!;
}
