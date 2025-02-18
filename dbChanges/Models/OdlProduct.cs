using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OdlProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public double? ProductVersion { get; set; }

    public virtual ICollection<ControlSystemIntegratorProductM2m> ControlSystemIntegratorProductM2ms { get; } = new List<ControlSystemIntegratorProductM2m>();

    public virtual ICollection<DistributorProductM2m> DistributorProductM2ms { get; } = new List<DistributorProductM2m>();

    public virtual ICollection<Permission> Permissions { get; } = new List<Permission>();

    public virtual ICollection<Role> Roles { get; } = new List<Role>();
}
