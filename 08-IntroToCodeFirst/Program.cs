// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//kodlarımızı yazacağız databaseimiz oluşacak.
//class->database
//nugetten ilgili entity framework itemlerini indirdikten sonra classı üreterekten giriyoruz işe.
//DbContext bir classtır 
//database bağlantısının yönetimi
//modeller ve db ilişkilerinin yönetimi
//database sorguları yönetimi
//veri kaydetme işlemleri
//değişiklikleri izleme vs.
//ben databaseim için önemli olan context classımı gerekli şeylerle popüle ettikten sonra entity frameworkte bulunan dbcontext sınıfından miras aldırtarak bu yukarda sayılan görevleri kendi oluşturduğum contexte de yaptırmış oluyorum.
//tablo olarak oluşsun istiyorsan classın DbSet şeklinde context sınıfında belirtmelisin.
//migration yazılan sınıfların veritabanına göç eylemesi. codefirstün en önemli kısmı olduğu rivayet edilir.
//9.proje contextinin içinde güzel notlar mevcut.
