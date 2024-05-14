using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class PackageMaterial
{
    public int MaterialId { get; set; }

    public string MaterialName { get; set; } = null!;

    public string? Picture { get; set; }

    public int? ColorId { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<Bag> Bags { get; set; } = new List<Bag>();

    public virtual ICollection<Box> Boxes { get; set; } = new List<Box>();

    public virtual MaterialColor? Color { get; set; }

    public virtual ICollection<TAllPackage> TAllPackages { get; set; } = new List<TAllPackage>();
}
