using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class RolePermissionM2m
{
    public int Id { get; set; }

    public int? RoleIdFk { get; set; }

    public int? PermissionIdFk { get; set; }

    public bool? CanRead { get; set; }

    public bool? CanUpdate { get; set; }

    public bool? CanCreate { get; set; }

    public bool? CanDelete { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual Permission? PermissionIdFkNavigation { get; set; }

    public virtual Role? RoleIdFkNavigation { get; set; }
}
