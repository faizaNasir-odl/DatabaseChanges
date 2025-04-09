using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthAlert
{
    public int Id { get; set; }

    public int? AssetIdFk { get; set; }

    public int? ParameterIdFk { get; set; }

    public bool? IsActiveAnomaly { get; set; }

    public DateTime? EventTime { get; set; }

    public bool? IsActiveAlert { get; set; }

    public bool? IsAlertAcknowledged { get; set; }

    public string? AlertAcknowledgedBy { get; set; }

    public DateTime? AlertAcknowledgedOn { get; set; }

    public bool? IsAlertIgnored { get; set; }

    public string? AlertIgnoredBy { get; set; }

    public DateTime? AlertIgnoredOn { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? NotificationCount { get; set; }
}
