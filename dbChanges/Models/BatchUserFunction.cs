using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchUserFunction
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public string Query { get; set; } = null!;

    public bool IsPublished { get; set; }

    public bool Validated { get; set; }

    public int SiteId { get; set; }

    public int TenantId { get; set; }

    public string? FunctionSignature { get; set; }

    public string CreatedBy { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int? LanguageId { get; set; }

    public bool IsDeleted { get; set; }

    public string? DocString { get; set; }

    public virtual BatchJobQueryLanguage? Language { get; set; }
}
