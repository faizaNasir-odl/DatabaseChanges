using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Variable
{
    public int VId { get; set; }

    public string? VName { get; set; }

    public string? VSymbol { get; set; }

    public string? VMappedName { get; set; }

    public bool IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? SystemIntegratorIdFk { get; set; }

    public virtual ICollection<FormulaDependenciesMetrix> FormulaDependenciesMetrixes { get; set; } = new List<FormulaDependenciesMetrix>();

    public virtual ICollection<KpiFormulaVariableM2M> KpiFormulaVariableM2Ms { get; set; } = new List<KpiFormulaVariableM2M>();
}
