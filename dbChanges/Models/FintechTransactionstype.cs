using System;
using System.Collections.Generic;

namespace dbChanges.Models;

public partial class FintechTransactionstype
{
    public int Id { get; set; }

    public int? SiteId { get; set; }

    public int? SaleId { get; set; }

    public string? PayPaymentType { get; set; }

    public DateTime? LastModifiedDate { get; set; }

    public string? PayPaymentInfo { get; set; }

    public int? FcSiteId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
