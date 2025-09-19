using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserArea
{
    public int UserAreaId { get; set; }

    public string? UserIdFk { get; set; }

    public int? AreaIdFk { get; set; }
}
