using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TDistrict
{
    public int DistrictId { get; set; }

    public string? DistrictNamt { get; set; }

    public int? CityId { get; set; }

    public virtual City? City { get; set; }
}
