using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class City
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RegionidFk { get; set; }
}
