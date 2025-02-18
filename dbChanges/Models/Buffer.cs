using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Buffer
{
    public int Id { get; set; }

    public DateTime? ReceivedTime { get; set; }

    public string? Site { get; set; }

    public string? Customer { get; set; }

    public string? TimeStamp { get; set; }

    public string? Tags { get; set; }

    public DateTime? RetentionTime { get; set; }
}
