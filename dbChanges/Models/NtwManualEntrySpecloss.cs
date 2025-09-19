using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NtwManualEntrySpecloss
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public double? CbPmloss { get; set; }

    public double? Gfloss { get; set; }

    public double? Ayloss { get; set; }

    public double? Clloss { get; set; }

    public double? Totalloss { get; set; }
}
