using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ImportFile
{
    public int ImportId { get; set; }

    public byte[]? ImportUploadedFile { get; set; }

    public byte[]? ImportResultFile { get; set; }

    public int? SiteIdFk { get; set; }

    public string? ImportBy { get; set; }

    public bool? ImportStatus { get; set; }

    public DateTime? ImportStartDate { get; set; }

    public DateTime? ImportEndDate { get; set; }

    public virtual ICollection<ImportFileStatus> ImportFileStatuses { get; } = new List<ImportFileStatus>();
}
