using System;
using System.Collections.Generic;

namespace _02_DataBaseFirstWinApp.Models;

public partial class VwSupplierProduct
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal? UnitPrice { get; set; }

    public short? UnitsInStock { get; set; }

    public string? SupplierName { get; set; }
}
