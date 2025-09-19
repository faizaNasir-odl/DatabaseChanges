using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class HamtransformRule
{
    public int RuleId { get; set; }

    public int SourceId { get; set; }

    public string TimestampField { get; set; } = null!;

    public string TagField { get; set; } = null!;

    public string ValueField { get; set; } = null!;

    public string? TypeConversions { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual HamdataSource Source { get; set; } = null!;
}
