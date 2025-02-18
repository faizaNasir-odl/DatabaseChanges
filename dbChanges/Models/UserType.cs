using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserType
{
    public int UserTypeId { get; set; }

    public string? UserType1 { get; set; }

    public bool? IsActive { get; set; }
}
