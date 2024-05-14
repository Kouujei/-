using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class Card
{
    public int CardId { get; set; }

    public string CardType { get; set; } = null!;

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public decimal? Price { get; set; }

    public int? SuitableProductsId { get; set; }

    public int? PstlyeId { get; set; }

    public virtual GiftPackageStyle? Pstlye { get; set; }
}
