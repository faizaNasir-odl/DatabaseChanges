using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Permission
{
    public int PermissionId { get; set; }

    public string? PermissionName { get; set; }

    public string? PermissionNameAlias { get; set; }

    public bool? CanRead { get; set; }

    public bool? CanUpdate { get; set; }

    public bool? CanCreate { get; set; }

    public bool? CanDelete { get; set; }

    public bool? IsActive { get; set; }

    public int? PermissionCategoryId { get; set; }

    public int? ProductIdFk { get; set; }

    public virtual OdlProduct? ProductIdFkNavigation { get; set; }

    public virtual ICollection<RolePermissionM2m> RolePermissionM2ms { get; set; } = new List<RolePermissionM2m>();
}
