using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorDatatypeInterimService
{
    public int Id { get; set; }

    public string? DataType { get; set; }

    public virtual ICollection<EnpConnectorDatatypeSapHanaAzureSql> EnpConnectorDatatypeSapHanaAzureSqls { get; set; } = new List<EnpConnectorDatatypeSapHanaAzureSql>();
}
