using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FormulaLibraryHistory
{
    public int FormulaLibId { get; set; }

    public string? Formula { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string HistoryType { get; set; } = null!;

    public byte[] TimeStamp { get; set; } = null!;
}
