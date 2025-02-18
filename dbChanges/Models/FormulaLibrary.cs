using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FormulaLibrary
{
    public int FormulaLibId { get; set; }

    public string? Formula { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<AssetLibrary> AssetLibIdFks { get; } = new List<AssetLibrary>();
}
