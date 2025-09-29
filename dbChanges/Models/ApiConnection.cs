using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApiConnection
{
    public int ApiConnectionId { get; set; }

    public string ApiName { get; set; } = null!;

    public string BaseUrl { get; set; } = null!;

    public string AuthType { get; set; } = null!;

    public string? Username { get; set; }

    public string? Password { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? Scope { get; set; }

    public string? TokenEndpoint { get; set; }

    public string? SiteId { get; set; }

    public string? TenantId { get; set; }

    public string RequestMethod { get; set; } = null!;

    public string? RequestPayloadTemplate { get; set; }

    public string? HeadersTemplate { get; set; }

    public string? JsonPath { get; set; }

    public string? ResponseFormat { get; set; }

    public bool IsWideFormat { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? Payload { get; set; }

    public string? SiteName { get; set; }

    public string? StartPath { get; set; }

    public string? EndPath { get; set; }
}
