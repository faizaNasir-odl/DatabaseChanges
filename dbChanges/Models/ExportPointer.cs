using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExportPointer
{
    public int PointerId { get; set; }

    public DateTime? MaxTimeStamp { get; set; }

    public int? JobId { get; set; }

    public int? TriggerId { get; set; }

    public DateTime InsertedOn { get; set; }
}
