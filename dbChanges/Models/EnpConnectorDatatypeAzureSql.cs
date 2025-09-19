using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorDatatypeAzureSql
{
    public int Id { get; set; }

    public string? DataType { get; set; }

    public virtual ICollection<EnpConnectorDatatypeSapHanaAzureSql> EnpConnectorDatatypeSapHanaAzureSqls { get; set; } = new List<EnpConnectorDatatypeSapHanaAzureSql>();
}
