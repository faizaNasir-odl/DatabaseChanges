using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class CountryCode
{
    public int CodeId { get; set; }

    public string? Code { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RecipientsInfo> RecipientsInfos { get; } = new List<RecipientsInfo>();
}
