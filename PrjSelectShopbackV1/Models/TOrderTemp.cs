using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TOrderTemp
{
    public int OrderId { get; set; }

    public string? Gui { get; set; }

    public DateTime? OrderDate { get; set; }

    public int? MemberId { get; set; }

    public int? StatusId { get; set; }

    public int? RecMemberId { get; set; }

    public int? Shipping { get; set; }
}
