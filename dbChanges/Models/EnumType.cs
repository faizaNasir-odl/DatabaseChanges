using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnumType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Type { get; set; } = null!;

    public int EnumId { get; set; }

    public DateTime LastModified { get; set; }
}
