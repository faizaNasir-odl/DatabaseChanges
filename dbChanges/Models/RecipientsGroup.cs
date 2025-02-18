using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RecipientsGroup
{
    public int GroupId { get; set; }

    public string? GroupName { get; set; }

    public bool? IsEmailActive { get; set; }

    public bool? IsSmsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? SiId { get; set; }

    public virtual ICollection<NotificationEventsConfigM2m> NotificationEventsConfigM2ms { get; } = new List<NotificationEventsConfigM2m>();

    public virtual ICollection<RecipientsInfo> RecipientsInfos { get; } = new List<RecipientsInfo>();
}
