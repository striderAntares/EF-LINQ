//TEMEL ops (CRUD)
//DbSet nesnesi, bellekteki varlıkların kolleksiyonlarını temsil eder. Bir DbSet'in içeriğinde yaptığınız herhangi bir değişiklik, yalnızca DbContext'in SaveChanges metodu çağrıldığında veritabanına kaydolur.


#region ADD
//Add - Entity eklemek için DbSet.Add metodu kullanılır:

using _09_Model_DBContext_DBSet.Context;
using _09_Model_DBContext_DBSet.Entities;

//var author = new Author() { FirstName = "William", LastName = "Shakespeare" };
//using (var context = new AppDBContext())
//{
//    context.Authors.Add(author); //yazarı rame ekler
//    context.SaveChanges(); //değişiklikleri veritabanına ekler.
//}
#endregion


#region Read


//using (var context = new AppDBContext())
//{
//    Author yazar = context.Authors.Single(a => a.AuthorID == 2);

//    Console.WriteLine($"Author name: {yazar.FirstName} {yazar.LastName} ");
//}

//using (var context = new AppDBContext())
//{
//    Author yazar = context.Authors.FirstOrDefault(a => a.LastName == "Shakespeare");

//    Console.WriteLine($"Author name: {yazar.FirstName} {yazar.LastName} ");
//}

//using (var context = new AppDBContext())
//{
//    Author yazar = context.Authors.Find(1);

//    Console.WriteLine($"Author name: {yazar.FirstName} {yazar.LastName} ");
//} //primary key vermek zorundayız find ile

//birden çok entity döndürmek için kullanılan en yaygın metot ToList:
//using (var context = new AppDBContext())
//{
//    List<Author> yazar = context.Authors.ToList();

//    foreach (var yazarro in yazar)
//    {
//        Console.WriteLine($"{yazarro.FirstName} {yazarro.LastName}");
//    }
//}
#endregion

#region Update
//using (var context = new AppDBContext())
//{
//    Author author = context.Authors.Find(1);
//    author.LastName = "Jones";
//    //context.Authors.Update(author);(Optional)
//    context.SaveChanges();
//}
#endregion


#region Delete
//using (var context = new AppDBContext())
//{
//    Author author = context.Authors.Find(1); //find and store it
//    context.Authors.Remove(author); //remove it
//    context.SaveChanges(); //save it
//}
#endregion

//Kitap ekle Create
//using (var context = new AppDBContext())
//{
//    Author yazar = context.Authors.Single(a => a.FirstName == "William"); //kitabı eklemek istediğin yazarı yakala iyi de 2 yazıp ikiyi yakaladın amk findla yapma.
//    Book book = new Book(); //kitap instance alarak üret
//    book.Title = "Othello"; //populate
//    book.AuthorID = yazar.AuthorID; //assign
//    context.Books.Add(book); //add to ram
//    context.SaveChanges(); //save to database
//}

//Kitap oku Read
using (var context = new AppDBContext())
{
    //Book book = context.Books.Single(b => b.BookID == 1);

    //Console.WriteLine($"{book.Title}"); //by {book.Author.FirstName} {book.Author.LastName} null reference hatası oluyor select ile yapmak lazım.

    //Book book = context.Books.Select(b=> new {b.BookID, b.Title, b.Author.FirstName,b.Author.LastName }); select kullanırken bu amaçla yani bi classın içinde kolaylık olsun diye konmuş diğer classa erişmek istersen book cinsinden oluşturamazsın anynomous tip olur o yüzden var kullanmak lazım. anonim tipli veriler geçici olarak oluşturulmuş verilerdir atama yapılamaz. benim select kullanırken oluşturduğum query class içinde duran author listesiyle arasındaki bağlantıyı kuran öğedir. ondan direk listeye ulaşmamın da bir mantığı yok.

    var book = context.Books.Where(b => b.BookID == 1).Select(b => new { b.BookID, b.Title, b.Author.FirstName, b.Author.LastName });
//Console.WriteLine($"{book}") by {book.Author.FirstName} {book.Author.LastName} şimdi de içinde birden fazla şey olduğu üçün foreach kullanmalısın ve anonim olduğu için aslında daha çok.

foreach (var boo in book)
{
    Console.WriteLine($"{boo.Title} by {boo.FirstName} {boo.LastName}");
} // bir kaç ufak düzeltme ve artık hazır. Daha fazla filtreleme için yukarda obje oluşurken metotlar kullanılabilir.
}

//Kitap güncelle Update
//using (var context = new AppDBContext())
//{
    //var book = context.Books.Where(b => b.BookID == 1).Select(b => new { b.BookID, b.Title, b.Author.FirstName, b.Author.LastName });
    //foreach (var boo in book)
    //{
    //    boo.Title = "asd";
    //} // anonim tipe atama yaptırtmıyor sadece get özelliği var.

    //List<Author> auths = new List<Author>();
    //auths = context.Books.Select(b => new { b.Author });  //booksun içinde listeye ulaşma denemesi başarısız. new lediğin anda anonim oluyor.

    //Book book = context.Books.Find(1);
    //book.Author.FirstName = "Test";
    //context.SaveChanges(); //hocaya sor.

//    Book book = context.Books.Find(1);
//    book.Title = "King Lear";
//    context.SaveChanges();

//}

//Kitap Sil Delete
//using(var context = new AppDBContext())
//{
//    Book book = context.Books.Find(2);
//    context.Remove(book);
//    context.SaveChanges();
//}