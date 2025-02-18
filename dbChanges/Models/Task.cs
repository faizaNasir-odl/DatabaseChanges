using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Task
{
    public Guid Id { get; set; }

    public Guid Actionid { get; set; }

    public long TaskNumber { get; set; }

    public DateTime? Lastheartbeat { get; set; }

    public int? State { get; set; }

    public int? Type { get; set; }

    public Guid? Agentid { get; set; }

    public Guid? OwningInstanceid { get; set; }

    public DateTime? Creationtime { get; set; }

    public DateTime? Pickuptime { get; set; }

    public DateTime? Completedtime { get; set; }

    public byte[]? Request { get; set; }

    public byte[]? Response { get; set; }

    public int? Priority { get; set; }

    public int RetryCount { get; set; }

    public int DependencyCount { get; set; }

    public long Version { get; set; }

    public DateTime? Lastresettime { get; set; }

    public virtual Action Action { get; set; } = null!;

    public virtual ICollection<Task> Nexttasks { get; } = new List<Task>();

    public virtual ICollection<Task> Prevtasks { get; } = new List<Task>();
}
