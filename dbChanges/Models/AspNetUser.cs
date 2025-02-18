using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool? LockoutEnabled { get; set; }

    public int? AccessFailedCount { get; set; }

    public string UserName { get; set; } = null!;

    public int? CustomerIdFk { get; set; }

    public string? CellNumber { get; set; }

    public string? CreatedBy { get; set; }

    public int? UserTypeIdFk { get; set; }

    public bool? IsUserLoggedIn { get; set; }

    public DateTime? LastActivityStamp { get; set; }

    public string? CurrentLoggedInUserGuid { get; set; }

    public bool? IsAaduser { get; set; }

    public DateTime? LastSuccessfulLogin { get; set; }

    public DateTime? LastFaieldLogin { get; set; }

    public bool? IsSmsnotificationEnabled { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? NormalizedEmail { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public string? NormalizedUserName { get; set; }

    public string? ConcurrencyStamp { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public DateTime? ActivatedOn { get; set; }

    public string? LoginType { get; set; }

    public virtual ICollection<AspNetUserClaim> AspNetUserClaims { get; } = new List<AspNetUserClaim>();

    public virtual ICollection<AspNetUserLogin> AspNetUserLogins { get; } = new List<AspNetUserLogin>();

    public virtual Customer? CustomerIdFkNavigation { get; set; }

    public virtual ICollection<ExportSiteLayOutStatus> ExportSiteLayOutStatuses { get; } = new List<ExportSiteLayOutStatus>();

    public virtual ICollection<SystemAlarmAction> SystemAlarmActions { get; } = new List<SystemAlarmAction>();

    public virtual ICollection<UserControlSystemIntegratorM2m> UserControlSystemIntegratorM2ms { get; } = new List<UserControlSystemIntegratorM2m>();

    public virtual ICollection<UserCustomerM2m> UserCustomerM2ms { get; } = new List<UserCustomerM2m>();

    public virtual ICollection<UserDistributorM2m> UserDistributorM2ms { get; } = new List<UserDistributorM2m>();

    public virtual ICollection<UserRoleM2m> UserRoleM2ms { get; } = new List<UserRoleM2m>();

    public virtual ICollection<UserSiteM2m> UserSiteM2ms { get; } = new List<UserSiteM2m>();

    public virtual ICollection<AspNetRole> Roles { get; } = new List<AspNetRole>();
}
