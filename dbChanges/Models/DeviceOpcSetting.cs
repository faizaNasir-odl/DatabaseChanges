using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DeviceOpcSetting
{
    public int Id { get; set; }

    public string? OpcServerAddress { get; set; }

    public string? OpcUsername { get; set; }

    public string? OpcPassword { get; set; }

    public string? OpcMachineAddress { get; set; }

    public string? OpcMachineUsername { get; set; }

    public string? OpcMachinePassword { get; set; }

    public bool? OpcSecurity { get; set; }

    public int? DeviceId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
