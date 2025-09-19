using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class IttablesExportsDatum
{
    public string? CustomeridSap { get; set; }

    public double? AmountSap { get; set; }

    public string? TagNamOdbc { get; set; }

    public double? MaxOdbc { get; set; }

    public string? TagName { get; set; }

    public double? MaxTagValue { get; set; }

    public double? TotalValueSum { get; set; }

    public string? InstanceId { get; set; }
}
