using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpenAiconfigurationHistory
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public string EventType { get; set; } = null!;

    public string EventValue { get; set; } = null!;
}
