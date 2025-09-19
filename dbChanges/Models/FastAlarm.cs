using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FastAlarm
{
    public int Id { get; set; }

    public int? TagId { get; set; }

    public string? TagType { get; set; }

    public string? MappedName { get; set; }

    public int? DataAlarmId { get; set; }
}
