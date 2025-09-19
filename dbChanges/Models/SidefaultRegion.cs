using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SidefaultRegion
{
    public int Id { get; set; }

    public int CsiidFk { get; set; }

    public int RegionIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual SystemIntegrator CsiidFkNavigation { get; set; } = null!;

    public virtual AzureRegion RegionIdFkNavigation { get; set; } = null!;
}
