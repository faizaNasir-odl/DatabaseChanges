using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ErrorLog
{
    public int ErrorLogId { get; set; }

    public string? ErrorMessage { get; set; }

    public int? ErrorSeverity { get; set; }

    public int? ErrorState { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorProcedure { get; set; }

    public DateTime? ErrorTime { get; set; }
}
