using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConnectorFieldMapping
{
    public int MappingId { get; set; }

    public int ConnectorId { get; set; }

    public string SourceField { get; set; } = null!;

    public string SinkField { get; set; } = null!;

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public string? CreatedBy { get; set; }
}
