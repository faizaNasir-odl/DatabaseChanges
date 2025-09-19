using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Region
{
    public int RegionId { get; set; }

    public string? RegionName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CountryidFk { get; set; }
}
