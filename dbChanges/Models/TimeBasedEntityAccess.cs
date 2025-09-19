using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TimeBasedEntityAccess
{
    public int Id { get; set; }

    public int UserTypeM2mFk { get; set; }

    public int EntityId { get; set; }

    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual UserUserTypeM2m UserTypeM2mFkNavigation { get; set; } = null!;
}
