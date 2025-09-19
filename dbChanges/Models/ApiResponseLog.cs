using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApiResponseLog
{
    public long ResponseId { get; set; }

    public int ApiId { get; set; }

    public int? ResponseCode { get; set; }

    public string? ResponseBody { get; set; }

    public DateTime? LoggedOn { get; set; }

    public virtual ApiConfig1 Api { get; set; } = null!;
}
