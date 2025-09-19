using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AllStatsFinal1
{
    public string? TimeStamp { get; set; }

    public string? TagName { get; set; }

    public string? AvgValue { get; set; }

    public string? MinValue { get; set; }

    public string? MaxValue { get; set; }

    public string? StandardDeviation { get; set; }

    public string? Variance { get; set; }
}
