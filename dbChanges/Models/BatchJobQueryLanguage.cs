using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class BatchJobQueryLanguage
{
    public int Id { get; set; }

    public string LanguageName { get; set; } = null!;

    public virtual ICollection<BatchJobsDefinition> BatchJobsDefinitions { get; } = new List<BatchJobsDefinition>();

    public virtual ICollection<BpmActivity> BpmActivities { get; } = new List<BpmActivity>();
}
