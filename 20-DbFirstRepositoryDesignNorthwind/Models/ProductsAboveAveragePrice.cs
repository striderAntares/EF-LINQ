using System;
using System.Collections.Generic;

namespace _20_DbFirstRepositoryDesignNorthwind.Models;

public partial class ProductsAboveAveragePrice
{
    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }
}
