using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SubscriptionTag
{
    public int SubId { get; set; }

    public string? SubscriptionName { get; set; }

    public int? NoOfTags { get; set; }

    public virtual ICollection<PlantSite> PlantSites { get; } = new List<PlantSite>();
}
