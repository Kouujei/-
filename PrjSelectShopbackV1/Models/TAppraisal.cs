using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TAppraisal
{
    public int RankId { get; set; }

    public string? Rank { get; set; }

    public virtual ICollection<TReview> TReviews { get; set; } = new List<TReview>();
}
