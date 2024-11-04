using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxParameterOutputMapping
{
    public int Id { get; set; }

    public int? ParameterIdFk { get; set; }

    public int? OutputTagParameterIdFk { get; set; }
}
