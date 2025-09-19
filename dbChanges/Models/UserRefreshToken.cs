using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserRefreshToken
{
    public int Id { get; set; }

    public string UserId { get; set; } = null!;

    public string? RefreshToken { get; set; }

    public DateTime? TokenExpiry { get; set; }
}
