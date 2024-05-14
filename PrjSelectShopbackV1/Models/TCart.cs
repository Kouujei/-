using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TCart
{
    public int CartId { get; set; }

    public int? MemberId { get; set; }

    public int? ProductId { get; set; }

    public int? Qty { get; set; }

    public bool? Check { get; set; }

    public virtual TMember? Member { get; set; }

    public virtual TProduct? Product { get; set; }
}
