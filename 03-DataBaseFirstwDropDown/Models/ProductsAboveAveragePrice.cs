﻿using System;
using System.Collections.Generic;

namespace _03_DataBaseFirstwDropDown.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
