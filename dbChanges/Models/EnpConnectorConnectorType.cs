using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorConnectorType
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<EnpConnectorConnector> EnpConnectorConnectors { get; } = new List<EnpConnectorConnector>();
}
