using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DataAlarmActionHistory
{
    public int Id { get; set; }

    public int? DatId { get; set; }

    public int? DataAlarmId { get; set; }

    public int? AsId { get; set; }

    public int? StateId { get; set; }

    public DateTime? ActionStartDate { get; set; }

    public DateTime? ActionEndDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
