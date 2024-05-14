using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TProdAppearance
{
    public int PappearanceId { get; set; }

    public string? Size { get; set; }

    public string? Color { get; set; }

    public string? Shape { get; set; }

    public int? ProductId { get; set; }

    public virtual TProduct? Product { get; set; }
}
