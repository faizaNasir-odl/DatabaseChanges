using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserCustomerM2m
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public string? UserId { get; set; }

    public int? Sid { get; set; }

    public virtual Customer? Customer { get; set; }

    public virtual AspNetUser? User { get; set; }
}
