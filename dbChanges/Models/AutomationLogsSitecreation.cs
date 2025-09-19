using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AutomationLogsSitecreation
{
    public int Id { get; set; }

    public DateTime TimeStamp { get; set; }

    public int SiteId { get; set; }

    public string TypeOfExecution { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? Stage { get; set; }

    public string? Error { get; set; }

    public TimeOnly? ExecutionTime { get; set; }

    public string ExecutionId { get; set; } = null!;

    public int? DeviceId { get; set; }
}
