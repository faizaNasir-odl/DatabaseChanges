using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserActivityLogging
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Activity { get; set; }

    public string? Controller { get; set; }

    public string? Action { get; set; }

    public DateTime? ActivityTime { get; set; }
}
