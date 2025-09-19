using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Realstatstable
{
    public string? TagName { get; set; }

    public double? StandardDeviation { get; set; }

    public double? Variance { get; set; }
}
