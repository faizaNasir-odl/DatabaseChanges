using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ReadapiPayload
{
    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? SiteName { get; set; }

    public string? CustomerName { get; set; }

    public string? TagGranularity { get; set; }

    public bool? ProductionDatabase { get; set; }

    public string? TagAggregate { get; set; }

    public string? TagType { get; set; }

    public string? StartDatetime { get; set; }

    public string? EndDatetime { get; set; }

    public bool? UserFriendly { get; set; }

    public string? ItemType { get; set; }

    public string? ItemNames { get; set; }

    public string? ResponseFormat { get; set; }

    public string OrchestratorId { get; set; } = null!;

    public string? StatusQueryUri { get; set; }

    public string? StartDatetimeUpdated { get; set; }

    public string? EndDatetimeUpdated { get; set; }

    public bool? IsRetrieved { get; set; }

    public bool? StatusCode { get; set; }

    public bool? UtcTime { get; set; }

    public string? TsNow { get; set; }
}
