﻿using System;
using System.Collections.Generic;

namespace _07_LinQQueriesOnNorthwind.Models;

public partial class SummaryOfSalesByQuarter
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
