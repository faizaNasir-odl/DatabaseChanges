using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApiConfig1
{
    public int ApiId { get; set; }

    public string ApiName { get; set; } = null!;

    public string BaseUrl { get; set; } = null!;

    public string? Endpoint { get; set; }

    public string HttpMethod { get; set; } = null!;

    public string? Headers { get; set; }

    public string? RequestBody { get; set; }

    public string? TokenEndpoint { get; set; }

    public string? ClientId { get; set; }

    public string? ClientSecret { get; set; }

    public string? Scope { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual ICollection<ApiResponseLog> ApiResponseLogs { get; set; } = new List<ApiResponseLog>();
}
