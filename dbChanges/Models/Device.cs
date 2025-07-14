using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Device
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? SiteSpecificMappedId { get; set; }

    public string? Name { get; set; }

    public string? MqttPublishTopic { get; set; }

    public string? MqttUsername { get; set; }

    public string? MqttPassword { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? IotconnectionString { get; set; }

    public string? IoTedgeConnectionString { get; set; }

    public string? DevicePlatform { get; set; }

    public int? DeviceTypeIdFk { get; set; }

    public string? Description { get; set; }

    public DateTime? CertificationExpirationDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? DeletionInProgress { get; set; }

    public int? TemplateDeviceId { get; set; }

    public int? FormatIdfk { get; set; }

    public string? JiraTicketUrl { get; set; }

    public DateTime? TicketIssuedOn { get; set; }

    public bool? IsResolved { get; set; }

    public int? ScanInterval { get; set; }

    public virtual ICollection<DeviceDlSetting> DeviceDlSettings { get; } = new List<DeviceDlSetting>();

    public virtual ICollection<DeviceModbusSetting> DeviceModbusSettings { get; } = new List<DeviceModbusSetting>();

    public virtual ICollection<DeviceOpcServerM2m> DeviceOpcServerM2ms { get; } = new List<DeviceOpcServerM2m>();

    public virtual ICollection<DeviceTimeStampIdmapping> DeviceTimeStampIdmappings { get; } = new List<DeviceTimeStampIdmapping>();

    public virtual DeviceType? DeviceTypeIdFkNavigation { get; set; }

    public virtual ICollection<ModBusDeviceTagsImportStatus> ModBusDeviceTagsImportStatuses { get; } = new List<ModBusDeviceTagsImportStatus>();

    public virtual ICollection<OpcSourceTagsCm> OpcSourceTagsCms { get; } = new List<OpcSourceTagsCm>();

    public virtual ICollection<SourceTagImportStatus> SourceTagImportStatuses { get; } = new List<SourceTagImportStatus>();

    public virtual ICollection<TagLakeLastUpdate> TagLakeLastUpdates { get; } = new List<TagLakeLastUpdate>();
}
