using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class PlantSite
{
    public int SiteId { get; set; }

    public string? SiteName { get; set; }

    public string? OriginalSiteName { get; set; }

    public string? GeographicalLocation { get; set; }

    public int? IndustryType { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CustomerIdFk { get; set; }

    public string? EhConnection { get; set; }

    public string? AutomationTableName { get; set; }

    public int? SubId { get; set; }

    public int? RequestedSubId { get; set; }

    public byte[]? RowV { get; set; }

    public double? Longitude { get; set; }

    public double? Latitude { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? State { get; set; }

    public string? Address { get; set; }

    public string? Country { get; set; }

    public string? AdxRegion { get; set; }

    public int? CountryId { get; set; }

    public int? RegionId { get; set; }

    public int? CityId { get; set; }

    public decimal? Deadband { get; set; }

    public int? Persistence { get; set; }

    public bool? IsProductionEnv { get; set; }

    public bool? IsActive { get; set; }

    public string? TimeZone { get; set; }

    public bool? BulkConnectionStringStatus { get; set; }

    public virtual Customer? CustomerIdFkNavigation { get; set; }

    public virtual ICollection<DeviceDlSetting> DeviceDlSettings { get; } = new List<DeviceDlSetting>();

    public virtual ICollection<ExportSiteLayOutStatus> ExportSiteLayOutStatuses { get; } = new List<ExportSiteLayOutStatus>();

    public virtual SubscriptionTag? Sub { get; set; }

    public virtual ICollection<TagLakeLastUpdate> TagLakeLastUpdates { get; } = new List<TagLakeLastUpdate>();

    public virtual ICollection<WhatIfResult> WhatIfResults { get; } = new List<WhatIfResult>();
}
