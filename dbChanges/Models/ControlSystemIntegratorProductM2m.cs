using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ControlSystemIntegratorProductM2m
{
    public int Id { get; set; }

    public int? ProductId { get; set; }

    public int? Csiid { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual SystemIntegrator? Csi { get; set; }

    public virtual OdlProduct? Product { get; set; }
}
