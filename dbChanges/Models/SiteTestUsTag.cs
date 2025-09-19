using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SiteTestUsTag
{
    public long? Id { get; set; }

    public string? TagType { get; set; }

    public string? TagName { get; set; }

    public long? AssetId { get; set; }
}
