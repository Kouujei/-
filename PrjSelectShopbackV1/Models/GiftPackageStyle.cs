using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class GiftPackageStyle
{
    public int PstlyeId { get; set; }

    public string StyleName { get; set; } = null!;

    public string? Picture { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Bag> Bags { get; set; } = new List<Bag>();

    public virtual ICollection<Box> Boxes { get; set; } = new List<Box>();

    public virtual ICollection<Card> Cards { get; set; } = new List<Card>();

    public virtual ICollection<TAllPackage> TAllPackages { get; set; } = new List<TAllPackage>();
}
