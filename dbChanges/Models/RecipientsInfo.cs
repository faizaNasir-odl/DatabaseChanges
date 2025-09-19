using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RecipientsInfo
{
    public int RecipientInfoId { get; set; }

    public int? GroupId { get; set; }

    public string? RecipientName { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public int? CodeIdFk { get; set; }

    public bool? IsOcuser { get; set; }

    public virtual CountryCode? CodeIdFkNavigation { get; set; }

    public virtual RecipientsGroup? Group { get; set; }
}
