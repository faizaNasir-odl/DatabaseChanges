using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetArea
{
    public int AreaId { get; set; }

    public string? AreaName { get; set; }

    public int? ParentId { get; set; }

    public string? AreaLocation { get; set; }

    public string? Description { get; set; }

    public int SiteIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool IsActive { get; set; }
}
