using _07_LinQQueriesOnNorthwind.Models;
using System.Data.SqlTypes;
using System.Runtime.InteropServices;
//database first işlemlerinde önemli olan şey entity frameworkle database ve visual studio arasında bağ kurmak. sonra da bu kurduğun bağda işlemler yapabilmek için contextten bir instance alıp metod syntaxlarını kullanarak ve ya query syntaxlarını istenilen sonuçları bir değişkende tutmak ve bunu yazdırmak.,

//Tüm Employeeleri listeleyin 5-6 tane kolonu getirin
NorthwindContext db = new NorthwindContext();
var result1 = db.Employees.Select(e => new { e.EmployeeId, e.FirstName, e.LastName });
foreach (var employee in result1)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId} Employee Name: {employee.FirstName} {employee.LastName}");
}
Console.WriteLine(new String('*', 30));
//İlk Employee yi yazdırın
var result2 = db.Employees.ToList().FirstOrDefault();
Console.WriteLine($"Employee ID: {result2.EmployeeId} Employee Name: {result2.FirstName} {result2.LastName}");
Console.WriteLine(new String('*', 30));
// FirstName e göre sıralayıp son employee yi yazdırın
var result3 = db.Employees.OrderBy(e=>e.FirstName).LastOrDefault();
Console.WriteLine($"Employee ID: {result3.EmployeeId} Employee Name: {result3.FirstName} {result3.LastName}");
Console.WriteLine(new String('*', 30));
// İsmi A ile başlayan employee leri listeleyin
var result4 = db.Employees.Where(e => e.FirstName.StartsWith("A")).ToList();
foreach (var employee in result4)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId} Employee Name: {employee.FirstName} {employee.LastName}");
}
Console.WriteLine(new String('*', 30));
// İsmi A ile başlayan ilk Employee yi yazdırın
var result5 = db.Employees.Where(e => e.FirstName.StartsWith("A")).FirstOrDefault();
Console.WriteLine($"Employee ID: {result5.EmployeeId} Employee Name: {result5.FirstName} {result5.LastName}");
Console.WriteLine(new String('*', 30));
// İsmi içerisinde a harfi içeren employeeleri listeleyin
var result6 = db.Employees.Where(e => e.FirstName.Contains("A")).ToList();
foreach (var employee in result6)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId} Employee Name: {employee.FirstName} {employee.LastName}");
}
Console.WriteLine(new String('*', 30));
// İsmi içerisinde a harfi içeren ilk employee yi yazdırın
var result7 = db.Employees.Where(e => e.FirstName.Contains("A")).FirstOrDefault();
Console.WriteLine($"Employee ID: {result7.EmployeeId} Employee Name: {result7.FirstName} {result7.LastName}");
Console.WriteLine(new String('*', 30));
// Adı Andrew olan employee leri yazdırın
var result8 = db.Employees.Where(e => e.FirstName == "Andrew").ToList();
foreach (var employee in result8)
{
    Console.WriteLine($"Employee ID: {employee.EmployeeId} Employee Name: {employee.FirstName} {employee.LastName}");
}
Console.WriteLine(new String('8', 30));
// En pahalı productı yazdırın
var result9 = db.Products.Max(p => p.UnitPrice);
var result10 = db.Products.Where(p => p.UnitPrice == (decimal)result9).ToList();
foreach (var product in result10)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName}");
}
Console.WriteLine(new String('9', 30));
// En ucuz ürünü yazdırın
var result11 = db.Products.Where(p=>p.UnitPrice != 0).Min(p => p.UnitPrice);
var result12 = db.Products.Where(p => p.UnitPrice == (decimal)result11).ToList();
foreach (var product in result12)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName}");
}

Console.WriteLine(new String('1', 30));
// Fiyatı ortala fiyat üzerinde olan ürünleri yazdırın
var result13 = db.Products.Average(p => p.UnitPrice);
var result14 = db.Products.Where(p => p.UnitPrice >= (decimal)result13);
foreach (var product in result14)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName}");
}
Console.WriteLine(new String('2', 30));
// Product ları Stock sayısına göre sıralayın
var result15 = db.Products.OrderBy(p => p.UnitsInStock);
foreach (var product in result15)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName}");
}
Console.WriteLine(new String('3', 30));
// Product ları önce Stock sayısına göre sonra ProductName e göre büyükten küçüğe sıralayın
var result16 = db.Products.OrderByDescending(p => p.UnitsInStock).ThenByDescending(p => p.ProductName);
foreach (var product in result16)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName}");
}
Console.WriteLine(new String('4', 30));
// Order detaillar'da order bazında toplam satış tutarı 500 ve altında olan orderid'leri getir, toplam tutara göre sırala
var result18 = db.OrderDetails.GroupBy(od => new { od.OrderId, od.ProductId }).Select(od => new
{
    OrderId = od.Key.OrderId,
    ProductID = od.Key.ProductId,
    Sum = od.Sum(od => od.Quantity * od.UnitPrice * (1 - (decimal)od.Discount))
}).Where(od => od.Sum <= 500).ToList();

foreach (var orders in result18)
{
    Console.WriteLine($"OrderID: {orders.OrderId} ProductID: {orders.ProductID} Sum: {orders.Sum}");
}
Console.WriteLine(new String('5', 30));
// Tüm product ları category leri ile birlikte listele
var result17 = db.Products.Select(p => new {p.Category.CategoryName, p.ProductId, p.ProductName});
foreach (var product in result17)
{
    Console.WriteLine($"ProductID: {product.ProductId} Product Name: {product.ProductName} Category Name: {product.CategoryName}");
}
Console.WriteLine(new String('6', 30));

//ProductName, CategoryName, Suplier CompanyName ile birlikte yazdırın

var result19 = db.Products.Select(p => new { p.ProductName, p.Category.CategoryName, p.Supplier.CompanyName });
foreach (var product in result19)
{
    Console.WriteLine($"ProductName: {product.ProductName} CategoryName: {product.CategoryName} SupplierName: {product.CompanyName}");
}
Console.WriteLine(new String('7', 30));