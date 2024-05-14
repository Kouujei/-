using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TAgency
{
    public int AgencyId { get; set; }

    public string? AgencyName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public int? SupplierId { get; set; }

    public int? EnterpriseId { get; set; }

    public virtual TEnterprise? Enterprise { get; set; }

    public virtual ICollection<TSale> TSales { get; set; } = new List<TSale>();
}
