using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TagsDataType
{
    public int DataTypeId { get; set; }

    public string? DataTypeName { get; set; }

    public int? TagTypeId { get; set; }

    public string? TagTypeName { get; set; }

    public virtual ICollection<PipeLineTag> PipeLineTags { get; } = new List<PipeLineTag>();
}
