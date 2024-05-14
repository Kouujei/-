using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class ProductTop4Sale
{
    public decimal? GrossProfit { get; set; }

    public int? ProductId { get; set; }

    public string? ProductName { get; set; }
}
