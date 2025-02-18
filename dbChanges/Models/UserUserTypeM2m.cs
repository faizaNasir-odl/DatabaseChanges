using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserUserTypeM2m
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public int? UserTypeId { get; set; }

    public int? CustomerId { get; set; }

    public string? SiteIds { get; set; }

    public string? AreaIds { get; set; }

    public string? AssetIds { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<TimeBasedEntityAccess> TimeBasedEntityAccesses { get; } = new List<TimeBasedEntityAccess>();
}
