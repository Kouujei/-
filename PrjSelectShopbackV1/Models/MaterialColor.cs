using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class MaterialColor
{
    public int ColorId { get; set; }

    public string ColorName { get; set; } = null!;

    public string? Rgb { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<PackageMaterial> PackageMaterials { get; set; } = new List<PackageMaterial>();
}
