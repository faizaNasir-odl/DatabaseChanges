using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AzureSqlDataType
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;
}
