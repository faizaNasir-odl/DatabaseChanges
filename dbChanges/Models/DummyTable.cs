using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class DummyTable
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }
}
