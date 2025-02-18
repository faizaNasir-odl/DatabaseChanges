using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ChartType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;
}
