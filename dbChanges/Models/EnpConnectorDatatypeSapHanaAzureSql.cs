using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class EnpConnectorDatatypeSapHanaAzureSql
{
    public int Id { get; set; }

    public int? SapHanaId { get; set; }

    public int? InterimServiceId { get; set; }

    public int? AzureSqlId { get; set; }

    public virtual EnpConnectorDatatypeAzureSql? AzureSql { get; set; }

    public virtual EnpConnectorDatatypeInterimService? InterimService { get; set; }

    public virtual EnpConnectorDatatypeSapHana? SapHana { get; set; }
}
