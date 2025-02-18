using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Role
{
    public int RoleId { get; set; }

    public string? RoleName { get; set; }

    public int? ProductIdFk { get; set; }

    public bool? IsDefaultRole { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual OdlProduct? ProductIdFkNavigation { get; set; }

    public virtual ICollection<RolePermissionM2m> RolePermissionM2ms { get; } = new List<RolePermissionM2m>();

    public virtual ICollection<UserRoleM2m> UserRoleM2ms { get; } = new List<UserRoleM2m>();
}
