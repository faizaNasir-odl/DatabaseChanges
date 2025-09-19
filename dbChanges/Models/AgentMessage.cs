using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AgentMessage
{
    public Guid Guid { get; set; }

    public string? MessageId { get; set; }

    public string? ThreadId { get; set; }

    public string? Role { get; set; }

    public string? Content { get; set; }

    public DateTime? CreatedAt { get; set; }
}
