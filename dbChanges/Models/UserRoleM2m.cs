using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserRoleM2m
{
    public int Id { get; set; }

    public string? UserIdFk { get; set; }

    public int? RoleIdFk { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual Role? RoleIdFkNavigation { get; set; }

    public virtual AspNetUser? UserIdFkNavigation { get; set; }
}
