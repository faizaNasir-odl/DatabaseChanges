using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FormatTable
{
    public int Id { get; set; }

    public string FormatName { get; set; } = null!;

    public string FuncName { get; set; } = null!;

    public string? Description { get; set; }
}
