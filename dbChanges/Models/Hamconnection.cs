using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Hamconnection
{
    public int ConnectionId { get; set; }

    public string ConnectionName { get; set; } = null!;

    public string Host { get; set; } = null!;

    public int Port { get; set; }

    public string Username { get; set; } = null!;

    public string Password { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<HamdataSource> HamdataSources { get; set; } = new List<HamdataSource>();
}
