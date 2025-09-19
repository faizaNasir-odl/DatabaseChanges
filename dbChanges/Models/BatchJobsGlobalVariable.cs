using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobsGlobalVariable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Type { get; set; }

    public string? Value { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? BatchJobId { get; set; }

    public virtual BatchJobsDefinition? BatchJob { get; set; }

    public virtual AdxDataType TypeNavigation { get; set; } = null!;
}
