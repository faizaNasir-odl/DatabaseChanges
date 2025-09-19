using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmActivityLevel
{
    public int BpmId { get; set; }

    public Guid ActivityId { get; set; }

    public int Level { get; set; }
}
