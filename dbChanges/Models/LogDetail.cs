using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class LogDetail
{
    public int Id { get; set; }

    public int? LogIdFk { get; set; }

    public string? Description { get; set; }
}
