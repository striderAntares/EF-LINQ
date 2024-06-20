

using _01_DataBaseFirstCore.Models;

NorthwindContext northwindContext = new NorthwindContext(); //context classından instance alıp yapabiliyoruz.

//List<Product> products =    northwindContext.Products.ToList();

//foreach (Product product in products)
//{
//    Console.WriteLine(product.ProductName);
//}

//northwindContext.Products.Where(x => x.CategoryId == 2).OrderBy(x => x.ProductName).ToList().ForEach(x => Console.WriteLine(x.ProductName));

Select();

static void Select()
{
    using (NorthwindContext db = new NorthwindContext()) //garbage collectora gerek kalmadan yapar bu işi using
    {
        List<Employee> employees = db.Employees.ToList();

        foreach (var emp in employees)
        {
            Console.WriteLine($"ID: {emp.EmployeeId} Name: {emp.FirstName} Last Name: {emp.LastName}");
        }
        Console.WriteLine(new String('*', 30));
    }

}

//Add();
static void Add()
{
    using (NorthwindContext db = new NorthwindContext())
    {
        //veri tabanına eklenecek nesne oluşuyor
        Employee newEmployee = new Employee();
        //we populate
        newEmployee.FirstName = "Hash";
        newEmployee.LastName = "Rocket"; //mesela bu bilgiler uygulamadan geldi varsay bir combobox mesela.

        //oluşturduğumuz nesneyi contextteki listeye ekliyoruz
        db.Employees.Add(newEmployee);
        db.SaveChanges(); //bu kısım önemli bu kısım olmadan sadece rame ekler veritabanına ekleme kısmını bu yapar. etkilenen satır sayısını döner. 0dan büyükse insert etmiştir diye sayabiliriz.
        Select(); //sağlaması, proof
    }

}

//Update();
static void Update()
{
    using (var db = new NorthwindContext())
    {
        Employee emp = db.Employees.FirstOrDefault(x => x.FirstName == "Hash" && x.LastName == "Rocket");
        if (emp is not null) //eğer yukarıdaki sorgu boş dönerse null reference hatası almamak için bu koşulu ekledik.
        {
            emp.TitleOfCourtesy = "Racoon";
            emp.Title = "Prosthetics Enthusiast";

            db.SaveChanges();
        }
        else
            Console.WriteLine("Null olamaz");
        Select();
    }
} //10:56daki mevzuyu dinle bi daha. çok da gerek yok da bi bak işte.

//Remove();
static void Remove()
{
    using (NorthwindContext db = new NorthwindContext())
    {
        Employee removeEmployee =db.Employees.First(x => x.FirstName == "Huseyinn" && x.LastName == "Talo");

        db.Employees.Remove(removeEmployee);

        db.SaveChanges() ;

        Select();
    }
}
