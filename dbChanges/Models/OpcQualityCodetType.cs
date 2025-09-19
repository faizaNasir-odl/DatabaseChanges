using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcQualityCodetType
{
    public int SctId { get; set; }

    public string? SctTitle { get; set; }

    public int? ScId { get; set; }

    public virtual ICollection<OpcQualityCodetTypesDataAlarmM2m> OpcQualityCodetTypesDataAlarmM2ms { get; set; } = new List<OpcQualityCodetTypesDataAlarmM2m>();

    public virtual OpcQualityCode? Sc { get; set; }
}
