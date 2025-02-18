using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EventComponentLookup
{
    public int EcomponentId { get; set; }

    public string? EcategoryTitle { get; set; }

    public string? EcomponentTitle { get; set; }

    public string? EventNameLevel1 { get; set; }

    public string? EventNameLevel2 { get; set; }

    public string? EventNameLevel3 { get; set; }
}
