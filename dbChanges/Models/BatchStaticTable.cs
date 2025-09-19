using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchStaticTable
{
    public int Id { get; set; }

    public string TableName { get; set; } = null!;

    public string Description { get; set; } = null!;

    public int SiteId { get; set; }

    public int TenantId { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string UpdatedBy { get; set; } = null!;

    public DateTime UpdatedAt { get; set; }

    public bool Published { get; set; }

    public bool IsDeleted { get; set; }

    public virtual ICollection<BatchStaticTableColumn> BatchStaticTableColumns { get; set; } = new List<BatchStaticTableColumn>();
}
