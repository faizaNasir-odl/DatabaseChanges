using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ModBusDeviceTagsImportStatus
{
    public int Id { get; set; }

    public int? TotalRecords { get; set; }

    public int? SuccessfullRecords { get; set; }

    public int? UnSuccessfullRecords { get; set; }

    public DateTime? ImportStartDate { get; set; }

    public DateTime? ImportEndDate { get; set; }

    public bool? ProcessStatus { get; set; }

    public int? DeviceIdFk { get; set; }

    public string? ImportByUser { get; set; }

    public byte[]? ImportFile { get; set; }

    public byte[]? ResultFile { get; set; }

    public virtual Device? DeviceIdFkNavigation { get; set; }
}
