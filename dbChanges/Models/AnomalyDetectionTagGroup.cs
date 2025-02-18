using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionTagGroup
{
    public int Id { get; set; }

    public string TagGroupName { get; set; } = null!;

    public string? Customer { get; set; }

    public string? SiteName { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<AnomalyDetectionTag> AnomalyDetectionTags { get; } = new List<AnomalyDetectionTag>();
}
