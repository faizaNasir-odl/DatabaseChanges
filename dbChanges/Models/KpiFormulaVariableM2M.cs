using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class KpiFormulaVariableM2M
{
    public int FvM2mId { get; set; }

    public int VId { get; set; }

    public int FId { get; set; }

    public bool? IsActive { get; set; }

    public virtual KpiFormula FIdNavigation { get; set; } = null!;

    public virtual Variable VIdNavigation { get; set; } = null!;
}
