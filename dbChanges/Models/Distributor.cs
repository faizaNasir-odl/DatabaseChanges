using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Distributor
{
    public int DistributorId { get; set; }

    public int? ParentDistributorId { get; set; }

    public bool? CanCreateDistributor { get; set; }

    public string? DistributorName { get; set; }

    public byte[]? Logo { get; set; }

    public string? Email { get; set; }

    public string? ContactNumber { get; set; }

    public string? StreetAddress { get; set; }

    public string? ZipCode { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<DistributorProductM2m> DistributorProductM2ms { get; set; } = new List<DistributorProductM2m>();

    public virtual ICollection<SystemIntegrator> SystemIntegrators { get; set; } = new List<SystemIntegrator>();

    public virtual ICollection<UserDistributorM2m> UserDistributorM2ms { get; set; } = new List<UserDistributorM2m>();
}
