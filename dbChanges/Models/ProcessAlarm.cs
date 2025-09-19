using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ProcessAlarm
{
    public int ProcessAlarmId { get; set; }

    public int? RealTagId { get; set; }

    public int? CTagId { get; set; }

    public string? AName { get; set; }

    public bool? IsActive { get; set; }

    public string? Description { get; set; }

    public DateTime? AStartTime { get; set; }

    public DateTime? AExpirationTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? SiteId { get; set; }

    public virtual ICollection<AlarmStatesConfig> AlarmStatesConfigs { get; set; } = new List<AlarmStatesConfig>();

    public virtual ICollection<AlarmsNotification> AlarmsNotifications { get; set; } = new List<AlarmsNotification>();

    public virtual CalculatedTag? CTag { get; set; }

    public virtual RealRawPoint? RealTag { get; set; }
}
