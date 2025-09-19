using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AlarmRecipientM2m
{
    public int ArmId { get; set; }

    public int? AstId { get; set; }

    public int? ArId { get; set; }

    public bool? IsEmailctive { get; set; }

    public bool? IsSmsactive { get; set; }

    public int? GrId { get; set; }

    public virtual AlarmRecipient? Ar { get; set; }

    public virtual AlarmStatesConfig? Ast { get; set; }

    public virtual RecipientGroup? Gr { get; set; }
}
