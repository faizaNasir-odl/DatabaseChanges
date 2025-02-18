using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NotificationEventsConfigM2m
{
    public int Id { get; set; }

    public int? EventIdFk { get; set; }

    public int? GroupIdFk { get; set; }

    public int? SiteIdFk { get; set; }

    public int? CustomerIdFk { get; set; }

    public bool? IsEmailActive { get; set; }

    public bool? IsSmsActive { get; set; }

    public int? DataAlarmIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? AlarmDuration { get; set; }

    public virtual DataAlarm? DataAlarmIdFkNavigation { get; set; }

    public virtual NotificationEvent? EventIdFkNavigation { get; set; }

    public virtual RecipientsGroup? GroupIdFkNavigation { get; set; }
}
