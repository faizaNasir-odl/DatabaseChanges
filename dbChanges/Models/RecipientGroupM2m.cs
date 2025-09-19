using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RecipientGroupM2m
{
    public int RgId { get; set; }

    public int? GrId { get; set; }

    public int? ArId { get; set; }

    public virtual AlarmRecipient? Ar { get; set; }

    public virtual RecipientGroup? Gr { get; set; }
}
