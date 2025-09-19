using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmjobTableColumn
{
    public int Id { get; set; }

    public int Bpmid { get; set; }

    public string ColumnName { get; set; } = null!;

    public bool IsPublished { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? DataType { get; set; }

    public virtual BpmJob Bpm { get; set; } = null!;

    public virtual AdxDataType? DataTypeNavigation { get; set; }
}
