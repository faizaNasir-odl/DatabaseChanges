using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FormulaDependenciesMetrix
{
    public int FdmId { get; set; }

    public int? FormulaPId { get; set; }

    public int? VariableId { get; set; }

    public int? FormulaId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpadtedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? FStatus { get; set; }

    public bool? IsActive { get; set; }

    public virtual KpiFormula? Formula { get; set; }

    public virtual Variable? Variable { get; set; }
}
