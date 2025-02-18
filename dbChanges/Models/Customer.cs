using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class Customer
{
    public int CustomerId { get; set; }

    public string? CustomerName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? Country { get; set; }

    public string? Email { get; set; }

    public string? CellNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Description { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public DateTime? CreatdDate { get; set; }

    public string? CreatedBy { get; set; }

    public byte[]? LogoImage { get; set; }

    public int? CsiFk { get; set; }

    public int? CountryId { get; set; }

    public int? RegionId { get; set; }

    public int? CityId { get; set; }

    public virtual ICollection<AspNetUser> AspNetUsers { get; } = new List<AspNetUser>();

    public virtual ICollection<ConfigrationVersioning> ConfigrationVersionings { get; } = new List<ConfigrationVersioning>();

    public virtual SystemIntegrator? CsiFkNavigation { get; set; }

    public virtual ICollection<PlantSite> PlantSites { get; } = new List<PlantSite>();

    public virtual ICollection<UserCustomerM2m> UserCustomerM2ms { get; } = new List<UserCustomerM2m>();

    public virtual ICollection<UserSiteM2m> UserSiteM2ms { get; } = new List<UserSiteM2m>();
}
