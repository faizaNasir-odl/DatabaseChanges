using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class WriteBackProperty
{
    public int Id { get; set; }

    public int LogIdFk { get; set; }

    public string? Key { get; set; }

    public string? Value { get; set; }

    public virtual WriteBackLog LogIdFkNavigation { get; set; } = null!;
}
