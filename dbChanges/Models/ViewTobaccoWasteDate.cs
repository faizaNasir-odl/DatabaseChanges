using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ViewTobaccoWasteDate
{
    public string? Day { get; set; }

    public DateTime? Prev { get; set; }

    public DateTime? Curr { get; set; }

    public DateTime? TwoPrev { get; set; }
}
