using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class PipeLineTag
{
    public int PltagsId { get; set; }

    public int? PipeLineId { get; set; }

    public bool? IsActive { get; set; }

    public int? DataTypeIdFk { get; set; }

    public string? Tagslist { get; set; }
}
