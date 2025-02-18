using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RecipientGroup
{
    public int GrId { get; set; }

    public string? GrTitle { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual ICollection<AlarmRecipientM2m> AlarmRecipientM2ms { get; } = new List<AlarmRecipientM2m>();

    public virtual ICollection<RecipientGroupM2m> RecipientGroupM2ms { get; } = new List<RecipientGroupM2m>();
}
