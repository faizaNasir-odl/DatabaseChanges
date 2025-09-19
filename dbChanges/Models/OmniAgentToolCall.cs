using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OmniAgentToolCall
{
    public int Id { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ThreadId { get; set; }

    public string? CallId { get; set; }

    public string? Arguments { get; set; }

    public string? Type { get; set; }

    public string? Output { get; set; }

    public string? ResponseId { get; set; }

    public string? ToolName { get; set; }

    public string? ToolCallId { get; set; }

    public string? Status { get; set; }

    public string? State { get; set; }
}
