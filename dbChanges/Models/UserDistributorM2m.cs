using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class UserDistributorM2m
{
    public int Id { get; set; }

    public int? DistributorIdFk { get; set; }

    public string? UserIdFk { get; set; }

    public bool? IsActive { get; set; }

    public string? CreatedByUser { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? UpdatedByUser { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public bool? IsOdladmin { get; set; }

    public virtual Distributor? DistributorIdFkNavigation { get; set; }

    public virtual AspNetUser? UserIdFkNavigation { get; set; }
}
