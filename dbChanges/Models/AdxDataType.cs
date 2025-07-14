using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AdxDataType
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<BatchJobTableColumn> BatchJobTableColumns { get; } = new List<BatchJobTableColumn>();

    public virtual ICollection<BpmActivityGlobalVar> BpmActivityGlobalVars { get; } = new List<BpmActivityGlobalVar>();
}
