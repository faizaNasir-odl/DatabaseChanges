using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NtwManualEntryExtra
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public double? DailyCountSpeclossBlend { get; set; }

    public double? DailyCountSpecloss { get; set; }

    public double? AverageSpecloss { get; set; }

    public double? TotalSpecloss { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Type { get; set; }
}
