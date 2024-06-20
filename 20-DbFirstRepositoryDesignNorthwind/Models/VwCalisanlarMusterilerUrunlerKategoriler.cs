using System;
using System.Collections.Generic;

namespace _20_DbFirstRepositoryDesignNorthwind.Models;

public partial class VwCalisanlarMusterilerUrunlerKategoriler
{
    public string? EmployeeName { get; set; }

    public string? CustomerName { get; set; }

    public string ProductName { get; set; } = null!;

    public short? UnitsInStock { get; set; }

    public string? Kategoriler { get; set; }

    public decimal UnitPrice { get; set; }

    public short Quantity { get; set; }
}
