using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class ApxWhatIfInput
{
    public int Id { get; set; }

    public string? WhatIfInputData { get; set; }

    public bool? IsProgress { get; set; }

    public int? AssetIdFk { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? CreatedBy { get; set; }

    public string? Section { get; set; }
}
