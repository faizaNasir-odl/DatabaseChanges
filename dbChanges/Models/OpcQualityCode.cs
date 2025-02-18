using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcQualityCode
{
    public int ScId { get; set; }

    public string? ScTitle { get; set; }

    public virtual ICollection<OpcQualityCodetType> OpcQualityCodetTypes { get; } = new List<OpcQualityCodetType>();
}
