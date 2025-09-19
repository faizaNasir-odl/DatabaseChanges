using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FmLogin
{
    public int Id { get; set; }

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? Name { get; set; }
}
