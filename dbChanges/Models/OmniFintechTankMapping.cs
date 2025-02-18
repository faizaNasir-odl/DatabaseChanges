using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OmniFintechTankMapping
{
    public int Id { get; set; }

    public int? FcTankId { get; set; }

    public int? FcSiteId { get; set; }

    public int? OmniAssetId { get; set; }

    public int? OmniSiteId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Modified { get; set; }

    public DateTime? ModifiedBy { get; set; }

    public int? ProdIdFk { get; set; }

    public double? Capacity { get; set; }
}
