using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class KpiFormula
{
    public int FId { get; set; }

    public string? FName { get; set; }

    public string? FText { get; set; }

    public string? FDevloper { get; set; }

    public string? FDescription { get; set; }

    public DateTime? FCreationDate { get; set; }

    public string? FCreatedBy { get; set; }

    public DateTime? FUpdationDate { get; set; }

    public string? FUpdatedBy { get; set; }

    public bool? FIsGlobal { get; set; }

    public int? AcId { get; set; }

    public string? KpiFMappedName { get; set; }

    public int? Sid { get; set; }

    public bool? IsActive { get; set; }

    public virtual AssetCategory? Ac { get; set; }

    public virtual ICollection<FormulaDependenciesMetrix> FormulaDependenciesMetrixes { get; } = new List<FormulaDependenciesMetrix>();

    public virtual ICollection<KpiFormulaVariableM2M> KpiFormulaVariableM2Ms { get; } = new List<KpiFormulaVariableM2M>();

    public virtual ICollection<KpiSFormulaAttachment> KpiSFormulaAttachments { get; } = new List<KpiSFormulaAttachment>();

    public virtual SystemIntegrator? SidNavigation { get; set; }
}
