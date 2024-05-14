using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class ProductTotalSale
{
    public int? ProductId { get; set; }

    public string? ProductName { get; set; }

    public decimal? TotalSales { get; set; }

    public int? TotalSalesVolume { get; set; }

    public decimal? GrossProfit { get; set; }

    public decimal? SalesAverage { get; set; }

    public int? SalesMonth { get; set; }
}
