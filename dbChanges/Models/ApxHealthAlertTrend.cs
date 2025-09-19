using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthAlertTrend
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public int? ParameterIdFk { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Jsondata { get; set; }
}
