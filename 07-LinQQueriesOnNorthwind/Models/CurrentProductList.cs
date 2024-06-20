using System;
using System.Collections.Generic;

namespace _07_LinQQueriesOnNorthwind.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
