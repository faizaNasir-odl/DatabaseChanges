using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxAssetsStatus
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public bool? IsPerformanceConfigured { get; set; }

    public bool? IsPerformanceActivating { get; set; }

    public bool? IsPerformanceActivated { get; set; }

    public bool? IsPerformanceDeactivating { get; set; }

    public bool? IsPerformanceClearing { get; set; }

    public bool? IsHealthConfigured { get; set; }

    public bool? IsHealthActivating { get; set; }

    public bool? IsHealthActivated { get; set; }

    public bool? IsHealthDeactivating { get; set; }

    public bool? IsHealthClearing { get; set; }
}
