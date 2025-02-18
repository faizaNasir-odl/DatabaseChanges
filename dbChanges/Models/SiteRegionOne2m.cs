using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SiteRegionOne2m
{
    public int Id { get; set; }

    public int SiteIdFk { get; set; }

    public int RegionIdFk { get; set; }

    public string? ClusterUrl { get; set; }

    public string? ClusterName { get; set; }

    public string? JiraTicketUrl { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActivatedOn { get; set; }

    public virtual AzureRegion RegionIdFkNavigation { get; set; } = null!;
}
