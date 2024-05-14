using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TDistributor
{
    public int DistributorId { get; set; }

    public string? DistributorName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int? SupplierId { get; set; }

    public int? EnterpriseId { get; set; }

    public virtual TEnterprise? Enterprise { get; set; }

    public virtual ICollection<TSale> TSales { get; set; } = new List<TSale>();
}
