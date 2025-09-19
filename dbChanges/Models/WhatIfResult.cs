using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WhatIfResult
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public string? InputData { get; set; }

    public string? Section { get; set; }

    public string? OutputData { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public virtual Asset? AssetIdFkNavigation { get; set; }

    public virtual PlantSite? SiteIdFkNavigation { get; set; }
}
