using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class HamdataSource
{
    public int SourceId { get; set; }

    public string SourceName { get; set; } = null!;

    public string FileFormat { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public int ConnectionId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Hamconnection Connection { get; set; } = null!;

    public virtual ICollection<HamexecutionLog> HamexecutionLogs { get; set; } = new List<HamexecutionLog>();

    public virtual ICollection<HamtransformRule> HamtransformRules { get; set; } = new List<HamtransformRule>();
}
