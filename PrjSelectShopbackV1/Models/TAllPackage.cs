using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TAllPackage
{
    public int PackageId { get; set; }

    public string? PackName { get; set; }

    public decimal? Price { get; set; }

    public string? Picture { get; set; }

    public int? PackageStyleId { get; set; }

    public int? TypeId { get; set; }

    public int? MaterialId { get; set; }

    public virtual PackageMaterial? Material { get; set; }

    public virtual GiftPackageStyle? PackageStyle { get; set; }

    public virtual ICollection<TPackageWayDetail> TPackageWayDetails { get; set; } = new List<TPackageWayDetail>();
}
