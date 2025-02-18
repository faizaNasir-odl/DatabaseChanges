using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ChatMessage
{
    public int Id { get; set; }

    public string ChatThreadId { get; set; } = null!;

    public string UserMessage { get; set; } = null!;

    public string? AssistantResponse { get; set; }

    public DateTime? UserMessageTime { get; set; }

    public DateTime? AssistantResponseTime { get; set; }

    public int? Feedback { get; set; }

    public DateTime? CreatedAt { get; set; }

    public int? InputTokens { get; set; }

    public int? OutputTokens { get; set; }

    public decimal? InputTokensCost { get; set; }

    public decimal? OutputTokensCost { get; set; }

    public decimal? TotalMessageCost { get; set; }

    public string? Gptmodel { get; set; }

    public virtual ChatThread ChatThread { get; set; } = null!;
}
