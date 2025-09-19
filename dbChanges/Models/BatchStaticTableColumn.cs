using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchStaticTableColumn
{
    public int Id { get; set; }

    public string ColumnName { get; set; } = null!;

    public int? DataType { get; set; }

    public bool IsPublished { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int SiteId { get; set; }

    public int TenantId { get; set; }

    public int StaticTableId { get; set; }

    public virtual AdxDataType? DataTypeNavigation { get; set; }

    public virtual BatchStaticTable StaticTable { get; set; } = null!;
}
