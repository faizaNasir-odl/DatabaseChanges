using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class KpieIpTagsDatum
{
    public int TagDataId { get; set; }

    public int? TagVariableIdFk { get; set; }

    public int? CalTagIdFk { get; set; }

    public int? ManTagIdFk { get; set; }

    public int? RealTagIdFk { get; set; }

    public int? AssetIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }
}
