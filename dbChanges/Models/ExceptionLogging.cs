using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ExceptionLogging
{
    public int Id { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public string? ExceptionMessage { get; set; }

    public DateTime? ExceptionDate { get; set; }
}
