using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TSale
{
    public int SalesId { get; set; }

    public int? LabelId { get; set; }

    public int? AgencyId { get; set; }

    public int? DistribuatorId { get; set; }

    public virtual TAgency? Agency { get; set; }

    public virtual TDistributor? Distribuator { get; set; }

    public virtual TLabel? Label { get; set; }
}
