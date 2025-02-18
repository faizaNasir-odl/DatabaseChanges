using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Scaleunitlimit
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int MaxValue { get; set; }

    public DateTime LastModified { get; set; }
}
