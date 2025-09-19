using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SourceTagImportStatus
{
    public int Id { get; set; }

    public int? SiteIdFk { get; set; }

    public int? TotalRecords { get; set; }

    public int? SuccessfulRecords { get; set; }

    public DateTime? ImportStartDate { get; set; }

    public DateTime? ImportEndDate { get; set; }

    public bool? ProcessingStatus { get; set; }

    public int? DeviceId { get; set; }

    public virtual Device? Device { get; set; }
}
