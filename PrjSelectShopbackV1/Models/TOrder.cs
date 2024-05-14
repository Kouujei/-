using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TOrder
{
    public int OrderId { get; set; }

    public string? Gui { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? MemberId { get; set; }

    public int? StatusId { get; set; }

    public int? RecMemberId { get; set; }

    public int? Shipping { get; set; }

    public decimal? CheckoutAmount { get; set; }

    public virtual TMember? Member { get; set; }

    public virtual TStatus? Status { get; set; }

    public virtual ICollection<TPackageWayDetail> TPackageWayDetails { get; set; } = new List<TPackageWayDetail>();

    public virtual ICollection<TPurchase> TPurchases { get; set; } = new List<TPurchase>();
}
