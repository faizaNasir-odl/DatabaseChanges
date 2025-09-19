using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConversationHistory
{
    public Guid Id { get; set; }

    public string ConversationId { get; set; } = null!;

    public int StepNumber { get; set; }

    public string StepType { get; set; } = null!;

    public string? Content { get; set; }

    public string? Metadata { get; set; }

    public DateTime? Timestamp { get; set; }
}
