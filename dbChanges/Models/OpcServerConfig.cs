using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpcServerConfig
{
    public int Id { get; set; }

    public string? OpcServerAddress { get; set; }

    public string? OpcUsername { get; set; }

    public string? OpcPassword { get; set; }

    public bool? OpcSecurity { get; set; }

    public int? SiteId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<DeviceOpcServerM2m> DeviceOpcServerM2ms { get; } = new List<DeviceOpcServerM2m>();
}
