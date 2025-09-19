using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteBackParam
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int DeviceId { get; set; }

    public int SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
