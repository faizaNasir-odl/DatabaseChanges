using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FintechSiteShiftsConfiguration
{
    public int FsId { get; set; }

    public int? SiteId { get; set; }

    public DateTime? ShiftStartTime { get; set; }

    public DateTime? ShiftEndTime { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
