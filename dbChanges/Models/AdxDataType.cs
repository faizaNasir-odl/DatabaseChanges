using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AdxDataType
{
    public int Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<BatchJobTableColumn> BatchJobTableColumns { get; set; } = new List<BatchJobTableColumn>();

    public virtual ICollection<BatchJobsGlobalVariable> BatchJobsGlobalVariables { get; set; } = new List<BatchJobsGlobalVariable>();

    public virtual ICollection<BatchStaticTableColumn> BatchStaticTableColumns { get; set; } = new List<BatchStaticTableColumn>();

    public virtual ICollection<BpmActivityGlobalVar> BpmActivityGlobalVars { get; set; } = new List<BpmActivityGlobalVar>();

    public virtual ICollection<BpmjobTableColumn> BpmjobTableColumns { get; set; } = new List<BpmjobTableColumn>();
}
