using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AuditLog
{
    public int Id { get; set; }

    public string? UserIdFk { get; set; }

    public int? LogEventIdFk { get; set; }

    public DateTime? LoggedOn { get; set; }

    public string? Entity { get; set; }

    public string? ObjectIdFk { get; set; }

    public int? SiidFk { get; set; }
}
