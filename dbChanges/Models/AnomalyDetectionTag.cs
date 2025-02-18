using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionTag
{
    public int Id { get; set; }

    public int TagGroupId { get; set; }

    public string TagName { get; set; } = null!;

    public bool IsPredictor { get; set; }

    public bool IsTarget { get; set; }

    public virtual AnomalyDetectionTagGroup TagGroup { get; set; } = null!;
}
