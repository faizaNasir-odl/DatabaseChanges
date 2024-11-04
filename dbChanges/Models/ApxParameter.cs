using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxParameter
{
    public int Id { get; set; }

    public int? ParameterCategoryIdFk { get; set; }

    public string? ParameterName { get; set; }

    public int? Priority { get; set; }
}
