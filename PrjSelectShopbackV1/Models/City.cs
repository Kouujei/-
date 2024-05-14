using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class City
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public virtual ICollection<TDistrict> TDistricts { get; set; } = new List<TDistrict>();
}
