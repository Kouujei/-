using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TPackageWayDetail
{
    public int PackageWayDetailId { get; set; }

    public int? PackageId { get; set; }

    public int? OrderId { get; set; }

    public int? PackQty { get; set; }

    public virtual TOrder? Order { get; set; }

    public virtual TAllPackage? Package { get; set; }
}
