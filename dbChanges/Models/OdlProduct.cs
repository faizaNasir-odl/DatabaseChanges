using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OdlProduct
{
    public int ProductId { get; set; }

    public string? ProductName { get; set; }

    public double? ProductVersion { get; set; }

    public virtual ICollection<ControlSystemIntegratorProductM2m> ControlSystemIntegratorProductM2ms { get; set; } = new List<ControlSystemIntegratorProductM2m>();

    public virtual ICollection<DistributorProductM2m> DistributorProductM2ms { get; set; } = new List<DistributorProductM2m>();

    public virtual ICollection<Permission> Permissions { get; set; } = new List<Permission>();

    public virtual ICollection<Role> Roles { get; set; } = new List<Role>();
}
