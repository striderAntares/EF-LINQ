using System;
using System.Collections.Generic;

namespace _07_LinQQueriesOnNorthwind.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
