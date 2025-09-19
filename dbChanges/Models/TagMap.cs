using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TagMap
{
    public int TagMapId { get; set; }

    public string FriendlyName { get; set; } = null!;

    public string CanonicalName { get; set; } = null!;

    public int? SiteId { get; set; }

    public string? Units { get; set; }

    public int DefaultStatusCode { get; set; }

    public bool IsActive { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime UpdatedDate { get; set; }
}
