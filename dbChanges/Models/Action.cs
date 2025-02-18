using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Action
{
    public Guid Id { get; set; }

    public Guid? Syncgroupid { get; set; }

    public int Type { get; set; }

    public int State { get; set; }

    public DateTime? Creationtime { get; set; }

    public DateTime? Lastupdatetime { get; set; }

    public virtual ICollection<Task> Tasks { get; } = new List<Task>();
}
