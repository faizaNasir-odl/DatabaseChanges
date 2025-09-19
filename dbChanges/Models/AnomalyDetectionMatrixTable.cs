using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionMatrixTable
{
    public int Id { get; set; }

    public int? ModelledTagId { get; set; }

    public string? ModelledTagType { get; set; }

    public int? DependentTagId { get; set; }

    public string? DependentTagType { get; set; }

    public int? GroupId { get; set; }
}
