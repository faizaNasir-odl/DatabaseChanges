using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Device
{
    public int Id { get; set; }

    public string? Guid { get; set; }

    public string? SiteSpecificMappedId { get; set; }

    public string? Name { get; set; }

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
}
