using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AzureRegion
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public bool? AlreadyCreated { get; set; }

    public bool? SystemGenerated { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsActive { get; set; }

    public string? ClusterName { get; set; }

    public string? ClusterUrl { get; set; }

    public virtual ICollection<SidefaultRegion> SidefaultRegions { get; } = new List<SidefaultRegion>();

    public virtual ICollection<SiteRegionOne2m> SiteRegionOne2ms { get; } = new List<SiteRegionOne2m>();
}
