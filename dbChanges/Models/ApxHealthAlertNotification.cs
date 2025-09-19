using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxHealthAlertNotification
{
    public int Id { get; set; }

    public int AssetId { get; set; }

    public int NotificationGroupId { get; set; }
}
