using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BpmactivitiesHistory
{
    public int Id { get; set; }

    public int BpmId { get; set; }

    public string? ActivityType { get; set; }

    public Guid ActivityGuid { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? TableName { get; set; }

    public string? Query { get; set; }

    public string? ConvertedQuery { get; set; }

    public int? LanguageId { get; set; }

    public bool? Validate { get; set; }

    public bool? Published { get; set; }

    public bool? Executed { get; set; }

    public bool? IsDeleted { get; set; }

    public string? ActivityError { get; set; }

    public DateTime CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public string PublishedBy { get; set; } = null!;
}
