using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TriggeredDataAlarm
{
    public int Id { get; set; }

    public long? DataAlarmId { get; set; }

    public int? SiteId { get; set; }

    public string? SiteName { get; set; }

    public string? TagName { get; set; }

    public double? SetValue { get; set; }

    public double? UpperValue { get; set; }

    public double? LowerValue { get; set; }

    public string? Description { get; set; }

    public double? TriggeredValue { get; set; }

    public string? AlarmState { get; set; }

    public string? Recipents { get; set; }

    public bool? IsActive { get; set; }

    public string? RecipientsPhoneNumber { get; set; }
}
