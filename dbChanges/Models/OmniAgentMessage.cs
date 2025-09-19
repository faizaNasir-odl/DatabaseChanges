using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OmniAgentMessage
{
    public int Id { get; set; }

    public DateTime? TimeStamp { get; set; }

    public string? ThreadId { get; set; }

    public string? Message { get; set; }

    public bool? Role { get; set; }

    public string? ResponseId { get; set; }

    public string? MessageId { get; set; }

    public string? UserId { get; set; }

    public string? State { get; set; }

    public string? ChatTitle { get; set; }

    public string? ChannelPartner { get; set; }

    public string? CustomerName { get; set; }

    public string? SiteName { get; set; }

    public int? SiteIdFk { get; set; }

    public string? StateDe { get; set; }
}
