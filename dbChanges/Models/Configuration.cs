using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Configuration
{
    public int Id { get; set; }

    public string ConfigKey { get; set; } = null!;

    public string ConfigValue { get; set; } = null!;

    public DateTime LastModified { get; set; }
}
