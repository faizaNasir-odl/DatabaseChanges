using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Customtabletesting
{
    public string? TimeStamp { get; set; }

    public string? TagName { get; set; }

    public string? Starttime { get; set; }

    public string? Endtime { get; set; }

    public string? Duration { get; set; }

    public double? TrueVal { get; set; }

    public string? InstanceId { get; set; }
}
