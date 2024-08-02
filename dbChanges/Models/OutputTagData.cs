using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OutputTagData
{
    public int OutputTagId { get; set; }

    public int? CalTagIdFk { get; set; }

    public int? OutputParameterIdFk { get; set; }

    public int? AssetIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
