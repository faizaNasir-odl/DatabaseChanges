using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataAlarm
{
    public int DataAlarmId { get; set; }

    public int? RealTagId { get; set; }

    public int? CTagId { get; set; }

    public string? DataAlarmName { get; set; }

    public DateTime? AStartTime { get; set; }

    public DateTime? AExpirationTime { get; set; }

    public bool? IsDataAlarmOn { get; set; }

    public bool? IsStatAlarmOn { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual CalculatedTag? CTag { get; set; }

    public virtual ICollection<DataAlarmAction1> DataAlarmAction1s { get; } = new List<DataAlarmAction1>();

    public virtual ICollection<DataAlarmAction> DataAlarmActions { get; } = new List<DataAlarmAction>();

    public virtual ICollection<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; } = new List<DataAlarmStatesConfig>();

    public virtual ICollection<NotificationEventsConfigM2m> NotificationEventsConfigM2ms { get; } = new List<NotificationEventsConfigM2m>();

    public virtual ICollection<OpcQualityCodetTypesDataAlarmM2m> OpcQualityCodetTypesDataAlarmM2ms { get; } = new List<OpcQualityCodetTypesDataAlarmM2m>();

    public virtual RealRawPoint? RealTag { get; set; }
}
