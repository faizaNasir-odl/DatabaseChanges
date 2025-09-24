using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class AnomalyDetectionRelaxationFactorMap
{
    public int RelaxationFactor { get; set; }

    public double SigmaValue { get; set; }
}
