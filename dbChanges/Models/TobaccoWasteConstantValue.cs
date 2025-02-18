using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class TobaccoWasteConstantValue
{
    public int Id { get; set; }

    public double? ConstantCbpmOutputCf { get; set; }

    public double? ConstantCbPmCigCf { get; set; }

    public double? ConstantGfOutputCf { get; set; }

    public double? ConstantGfCigCf { get; set; }

    public double? ConstantClOutputCf { get; set; }

    public double? ConstantClCigCf { get; set; }

    public double? ConstantAyOutputCf { get; set; }

    public double? ConstantAyCihCf { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }
}
