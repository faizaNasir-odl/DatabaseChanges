using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SystemIntegrator
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? Phone { get; set; }

    public byte[]? LogoImage { get; set; }

    public string? PathImage { get; set; }

    public int? DistributorIdFk { get; set; }

    public int? CountryId { get; set; }

    public int? StateId { get; set; }

    public int? CityId { get; set; }

    public string? ZipCode { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<ControlSystemIntegratorProductM2m> ControlSystemIntegratorProductM2ms { get; set; } = new List<ControlSystemIntegratorProductM2m>();

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();

    public virtual Distributor? DistributorIdFkNavigation { get; set; }

    public virtual ICollection<KpiFormula> KpiFormulas { get; set; } = new List<KpiFormula>();

    public virtual ICollection<SidefaultRegion> SidefaultRegions { get; set; } = new List<SidefaultRegion>();

    public virtual ICollection<UserControlSystemIntegratorM2m> UserControlSystemIntegratorM2ms { get; set; } = new List<UserControlSystemIntegratorM2m>();
}
