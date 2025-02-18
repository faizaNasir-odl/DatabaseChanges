using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteBackLog
{
    public int Id { get; set; }

    public int DeviceId { get; set; }

    public int SiteId { get; set; }

    public DateTime CreatedOn { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public virtual ICollection<WriteBackProperty> WriteBackProperties { get; } = new List<WriteBackProperty>();
}
