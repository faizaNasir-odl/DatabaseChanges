using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EdgeConfigurationTimeLine
{
    public int Id { get; set; }

    public string? UserId { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public string? Emails { get; set; }

    public bool? IsUserReminder { get; set; }
}
