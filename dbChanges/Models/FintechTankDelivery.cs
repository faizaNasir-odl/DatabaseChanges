using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FintechTankDelivery
{
    public int? SiteId { get; set; }

    public int? TankId { get; set; }

    public DateOnly? DateStart { get; set; }

    public TimeOnly? TimeStart { get; set; }

    public decimal? VolTotal { get; set; }

    public DateOnly? DateEnd { get; set; }

    public TimeOnly? TimeEnd { get; set; }

    public decimal? VolStart { get; set; }

    public decimal? VolEnd { get; set; }

    public decimal? HeightStart { get; set; }

    public decimal? HeightEnd { get; set; }

    public decimal? TempStart { get; set; }

    public decimal? TempEnd { get; set; }

    public decimal? TransactionsVolume { get; set; }

    public decimal? WaterStart { get; set; }

    public decimal? WaterEnd { get; set; }

    public decimal? WaterHeightStart { get; set; }

    public decimal? WaterHeightEnd { get; set; }

    public int? DeliveryId { get; set; }

    public int? DeliveryNoteId { get; set; }

    public decimal? VolTcTotal { get; set; }

    public decimal? VolTcStart { get; set; }

    public decimal? VolTcEnd { get; set; }

    public string? SourceType { get; set; }

    public decimal? ProdDensityStart { get; set; }

    public decimal? ProdTcDensityStart { get; set; }

    public decimal? ProdDensityEnd { get; set; }

    public decimal? ProdTcDensityEnd { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public int Id { get; set; }

    public int? FcSiteId { get; set; }

    public int? OmniAssetId { get; set; }

    public int? ProductId { get; set; }
}
