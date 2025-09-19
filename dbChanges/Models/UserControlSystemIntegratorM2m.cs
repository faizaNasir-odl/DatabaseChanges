using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserControlSystemIntegratorM2m
{
    public int Id { get; set; }

    public int? CsiidFk { get; set; }

    public string? UserIdFk { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public virtual SystemIntegrator? CsiidFkNavigation { get; set; }

    public virtual AspNetUser? UserIdFkNavigation { get; set; }
}
