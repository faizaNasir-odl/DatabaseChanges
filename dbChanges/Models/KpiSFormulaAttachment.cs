using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class KpiSFormulaAttachment
{
    public int FaId { get; set; }

    public int? FId { get; set; }

    public string? FaName { get; set; }

    public string? FaUrl { get; set; }

    public string? FaDescription { get; set; }

    public virtual KpiFormula? FIdNavigation { get; set; }
}
