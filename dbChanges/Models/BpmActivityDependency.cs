using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmActivityDependency
{
    public int Id { get; set; }

    public int BpmId { get; set; }

    public Guid? ActivityId { get; set; }

    public Guid? ParentActivityId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }
}
