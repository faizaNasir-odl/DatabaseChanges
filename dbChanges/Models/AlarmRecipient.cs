using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmRecipient
{
    public int ArId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? ContactNumber { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? SiteId { get; set; }

    public virtual ICollection<AlarmRecipientM2m> AlarmRecipientM2ms { get; set; } = new List<AlarmRecipientM2m>();

    public virtual ICollection<RecipientGroupM2m> RecipientGroupM2ms { get; set; } = new List<RecipientGroupM2m>();
}
