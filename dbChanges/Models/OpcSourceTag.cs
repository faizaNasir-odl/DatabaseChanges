using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcSourceTag
{
    public int SourceTagId { get; set; }

    public string? SourceTagName { get; set; }

    public int? SiteIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? DataType { get; set; }

    public string? Description { get; set; }

    public string? TagAddress { get; set; }

    public int? OnPremSourceTagId { get; set; }

    public string? Unit { get; set; }

    public int? ScanRate { get; set; }

    public int? HeartBeatRate { get; set; }

    public int? PublishRate { get; set; }

    public int? SiteSpecificDeviceId { get; set; }

    public string? OpcServerId { get; set; }

    public bool? IsValid { get; set; }

    public string? Path { get; set; }

    public int? SourceTagParametersId { get; set; }

    public string? TagType { get; set; }

    public bool? IsActive { get; set; }

    public int? DlTagId { get; set; }

    public virtual ICollection<DeviceTimeStampIdmapping> DeviceTimeStampIdmappingIdSourceTagIdFkNavigations { get; } = new List<DeviceTimeStampIdmapping>();

    public virtual ICollection<DeviceTimeStampIdmapping> DeviceTimeStampIdmappingTimeStampSourceTagIdFkNavigations { get; } = new List<DeviceTimeStampIdmapping>();

    public virtual ICollection<OpcSourceTagsCm> OpcSourceTagsCms { get; } = new List<OpcSourceTagsCm>();
}
