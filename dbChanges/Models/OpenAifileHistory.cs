using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class OpenAifileHistory
{
    public int Id { get; set; }

    public string FileId { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public byte[]? FileContent { get; set; }

    public string UserId { get; set; } = null!;

    public bool IsUserManual { get; set; }

    public string FileSize { get; set; } = null!;

    public DateTime? UpdatedAt { get; set; }
}
