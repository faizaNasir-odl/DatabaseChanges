using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxInsightTab
{
    public int Id { get; set; }

    public int? AssetCategoryIdFk { get; set; }

    public string? TabName { get; set; }
}
