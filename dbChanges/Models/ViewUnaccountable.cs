using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ViewUnaccountable
{
    public DateTime? Curr { get; set; }

    public double? PmdUnaccountable { get; set; }

    public double? SmdUnaccountable { get; set; }
}
