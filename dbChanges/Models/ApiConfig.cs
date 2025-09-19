using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApiConfig
{
    public int Id { get; set; }

    public int SiteId { get; set; }

    public int IsCreated { get; set; }

    public string? ConsumerGroup { get; set; }
}
