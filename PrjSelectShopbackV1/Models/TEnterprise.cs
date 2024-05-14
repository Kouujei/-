using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TEnterprise
{
    public int EnterpriseId { get; set; }

    public string? EnterpriseName { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public virtual ICollection<TAgency> TAgencies { get; set; } = new List<TAgency>();

    public virtual ICollection<TDistributor> TDistributors { get; set; } = new List<TDistributor>();
}
