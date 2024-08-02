using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DesignDatum
{
    public int DesignDataId { get; set; }

    public int? DesignParameterIdFk { get; set; }

    public decimal? DataValue { get; set; }

    public int? AssetIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
