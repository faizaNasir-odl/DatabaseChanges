using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataAlarmState
{
    public int StateId { get; set; }

    public string? StateTitle { get; set; }

    public string? StateType { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<DataAlarmStatesConfig> DataAlarmStatesConfigs { get; set; } = new List<DataAlarmStatesConfig>();
}
