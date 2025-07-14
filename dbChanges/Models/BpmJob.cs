using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmJob
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public string Status { get; set; } = null!;

    public string? Description { get; set; }

    public int? TenantId { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string? TableName { get; set; }

    public string? Bpmjson { get; set; }

    public bool? Validated { get; set; }

    public bool? Published { get; set; }

    public bool? Executed { get; set; }

    public virtual ICollection<BpmActivity> BpmActivities { get; } = new List<BpmActivity>();

    public virtual ICollection<BpmActivityGlobalVar> BpmActivityGlobalVars { get; } = new List<BpmActivityGlobalVar>();

    public virtual ICollection<BpmjobsScheduling> BpmjobsSchedulings { get; } = new List<BpmjobsScheduling>();
}
