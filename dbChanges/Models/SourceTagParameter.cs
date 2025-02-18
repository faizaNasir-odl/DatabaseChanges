using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class SourceTagParameter
{
    public int SourceTagParametersId { get; set; }

    public string TagType { get; set; } = null!;

    public int SlaveId { get; set; }

    public string AddressMode { get; set; } = null!;

    public int ModbusAddress { get; set; }

    public int RegisterLength { get; set; }

    public int ModbusFunction { get; set; }

    public double? RangeMax { get; set; }

    public double? RangeMin { get; set; }
}
