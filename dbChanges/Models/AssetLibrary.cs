using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AssetLibrary
{
    public int AssetLibId { get; set; }

    public string? AssetName { get; set; }

    public string? AssetType { get; set; }

    public byte[]? AssetImage { get; set; }

    public virtual ICollection<FormulaLibrary> FormulaLibIdFks { get; set; } = new List<FormulaLibrary>();
}
