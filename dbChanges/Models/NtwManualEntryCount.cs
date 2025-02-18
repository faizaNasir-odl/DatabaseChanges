using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class NtwManualEntryCount
{
    public int Id { get; set; }

    public DateTime? Date { get; set; }

    public int? CbPmcount { get; set; }

    public int? Gfcount { get; set; }

    public int? Aycount { get; set; }

    public int? Clcount { get; set; }

    public int? Totalcount { get; set; }
}
