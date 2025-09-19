using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ImportFileStatus
{
    public int ImportStatusId { get; set; }

    public int? ImportIdFk { get; set; }

    public string? ImportEntity { get; set; }

    public int? TotalEntityRecords { get; set; }

    public int? SuccessfulRecords { get; set; }

    public int? UnsuccessfulRecords { get; set; }

    public string? ProcessingStatus { get; set; }

    public virtual ImportFile? ImportIdFkNavigation { get; set; }
}
