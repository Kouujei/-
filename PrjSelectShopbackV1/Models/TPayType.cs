﻿using System;
using System.Collections.Generic;

namespace PrjSelectShopbackV1.Models;

public partial class TPayType
{
    public int PayTypeId { get; set; }

    public string? PayKind { get; set; }

    public int? PayTypeNo { get; set; }

    public string? PayTypeName { get; set; }

    public string? PayTypeImagePath { get; set; }

    public virtual ICollection<TPay> TPays { get; set; } = new List<TPay>();
}
