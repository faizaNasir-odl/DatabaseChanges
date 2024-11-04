using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxStepsHeader
{
    public int Id { get; set; }

    public string? HeaderName { get; set; }

    public int? Priority { get; set; }

    public int? StepIdFk { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsUserInput { get; set; }
}
