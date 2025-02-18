using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ChatThread
{
    public int Id { get; set; }

    public string OpenAithreadId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string? ChatTitle { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime LastMessageAt { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<ChatMessage> ChatMessages { get; } = new List<ChatMessage>();
}
