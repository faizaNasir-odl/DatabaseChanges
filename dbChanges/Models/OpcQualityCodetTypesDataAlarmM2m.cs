using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcQualityCodetTypesDataAlarmM2m
{
    public int Id { get; set; }

    public int SctId { get; set; }

    public int DataAlarmId { get; set; }

    public bool? IsOn { get; set; }

    public bool IsActive { get; set; }

    public virtual DataAlarm DataAlarm { get; set; } = null!;

    public virtual OpcQualityCodetType Sct { get; set; } = null!;
}
