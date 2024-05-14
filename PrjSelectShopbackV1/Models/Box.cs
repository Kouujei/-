using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class Box
{
    public int BoxId { get; set; }

    public string BoxType { get; set; } = null!;

    public string? Description { get; set; }

    public string? Picture { get; set; }

    public decimal? Price { get; set; }

    public string? Size { get; set; }

    public int? MaterialId { get; set; }

    public int? SuitableProductsId { get; set; }

    public int? PstlyeId { get; set; }

    public virtual PackageMaterial? Material { get; set; }

    public virtual GiftPackageStyle? Pstlye { get; set; }
}
