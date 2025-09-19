using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobsDefinition
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int TableOption { get; set; }

    public string TableName { get; set; } = null!;

    public string? Query { get; set; }

    public int SiteId { get; set; }

    public int TenantId { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public int? LanguageId { get; set; }

    public bool Published { get; set; }

    public bool Validate { get; set; }

    public bool IsDeleted { get; set; }

    public string? ConvertedQuery { get; set; }

    public int? TemplateId { get; set; }

    public int? AssetId { get; set; }

    public bool IsTablePublished { get; set; }

    public DateTime? PublishedTableTime { get; set; }

    public virtual ICollection<BatchJobHistory> BatchJobHistories { get; set; } = new List<BatchJobHistory>();

    public virtual ICollection<BatchJobTableColumn> BatchJobTableColumns { get; set; } = new List<BatchJobTableColumn>();

    public virtual ICollection<BatchJobsGlobalVariable> BatchJobsGlobalVariables { get; set; } = new List<BatchJobsGlobalVariable>();

    public virtual ICollection<BatchJobsScheduling> BatchJobsSchedulings { get; set; } = new List<BatchJobsScheduling>();

    public virtual BatchJobQueryLanguage? Language { get; set; }
}
