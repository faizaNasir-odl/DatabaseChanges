using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BulkDeviceReplicationLogDevice
{
    public int Id { get; set; }

    public int LogId { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int SourceTagsCount { get; set; }

    public int SuccessfullSourceTags { get; set; }

    public int UnsuccessfullSourceTags { get; set; }

    public string? SourceTagsErrorMessage { get; set; }

    public int RawTagsCount { get; set; }

    public int SuccessfullRawTags { get; set; }

    public int UnsuccessfullRawTags { get; set; }

    public string? RawTagsErrorMessage { get; set; }

    public string DeviceStatus { get; set; } = null!;

    public virtual BulkDeviceReplicationLog Log { get; set; } = null!;
}
