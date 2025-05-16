using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FintechTankLevel
{
    public int Id { get; set; }

    public int? SiteId { get; set; }

    public int? TankId { get; set; }

    public string? ProductId { get; set; }

    public int? ProductNumber { get; set; }

    public double? ProductVolume { get; set; }

    public double? ProductHeight { get; set; }

    public double? WaterVolume { get; set; }

    public double? WaterHeight { get; set; }

    public double? ProductTemperature { get; set; }

    public string? DateLastRead { get; set; }

    public string? TimeLastRead { get; set; }

    public int? LastTransId { get; set; }

    public double? AccumVolume { get; set; }

    public string? IsAccum { get; set; }

    public double? DeliveryIniProductVolume { get; set; }

    public double? DeliveryIniProductHeight { get; set; }

    public double? DeliveryIniWaterVolume { get; set; }

    public double? DeliveryIniWaterHeight { get; set; }

    public string? DeliveryStartDate { get; set; }

    public string? DeliveryStartTime { get; set; }

    public int? ProbeStatus { get; set; }

    public string? DeliveryIniTemp { get; set; }

    public double? TcVolume { get; set; }

    public string? DateLastLeakTest { get; set; }

    public string? TimeLastLeakTest { get; set; }

    public string? LastModifiedDate { get; set; }

    public double? ProductDensity { get; set; }

    public double? ProductWeight { get; set; }

    public double? Ullage { get; set; }

    public double? DeliveredVolume { get; set; }

    public string? DeliveryState { get; set; }

    public string? ProdTcDensity { get; set; }

    public string? TimeStamp { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? FcSiteId { get; set; }

    public int? OmniAssetId { get; set; }

    public DateTime? FcTimeStamp { get; set; }
}
