using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ConnectorRestApi
{
    public int Id { get; set; }

    public int? ConnectIdFk { get; set; }

    public string? RestEndpoint { get; set; }

    public int? RestMethod { get; set; }

    public int? RestAuthType { get; set; }

    public string? RestAuthUsername { get; set; }

    public string? RestAuthPassword { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public int? TokenType { get; set; }

    public int? TokenMethod { get; set; }

    public string? TokenEndPoint { get; set; }
}
