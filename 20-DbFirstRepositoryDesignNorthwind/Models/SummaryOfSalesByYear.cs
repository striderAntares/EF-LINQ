﻿using System;
using System.Collections.Generic;

namespace _20_DbFirstRepositoryDesignNorthwind.Models;

public partial class SummaryOfSalesByYear
{
    public DateTime? ShippedDate { get; set; }

    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}