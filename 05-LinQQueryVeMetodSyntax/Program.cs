//Collection
//IList,ICollection - araştır buraları


using _05_LinQQueryVeMetodSyntax;

IList<Student> studentList = new List<Student>() 
{
    new Student() {studentID = 1, studentName = "John", Age = 18},
    new Student() {studentID = 2, studentName ="Steve", Age=15},
    new Student() {studentID = 3, studentName ="Bill", Age=25 },
    new Student() {studentID = 4, studentName = "Ram", Age = 20},
    new Student() {studentID = 5, studentName = "Ron", Age = 19}
};

#region QuerySyntax
//query syntax sorgu, veritabanına sorgu yazmak için T-SQL komutlarına benzer. C# içinde tanımlanan sorgu komutlarıdır.
//LİNQ sorgu sözdizimi fro anahtar kelimesi ile başlar ve select anahtar kelimesi ile biter
//Linq Query Syntax
//select*from student

var result1 = from s in studentList select s;

foreach (var item in result1)
{
    Console.WriteLine($"Query Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}

Console.WriteLine(new String('*',30));

//Select studentid, studentname from student (iki kolon seçmek)

var result2 = from s in studentList select new {s.studentID,s.studentName };

foreach (var item in result2)
{
    Console.WriteLine($"Query Syntax Id: {item.studentID} Name: {item.studentName}");
}

Console.WriteLine(new String('*', 30));
//select*from student order by studentName ASC
var result3 = from s in studentList orderby s.studentName ascending select s;
foreach (var item in result3)
{
    Console.WriteLine($"Query Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}
Console.WriteLine(new String('*', 30));
//select * from student where AGE >30 orderby studentname asc
var result4 = from s in studentList orderby s.studentName ascending where s.Age >=30  select s;
foreach (var item in result4)
{
    Console.WriteLine($"Query Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}
#endregion

#region MethodSyntax
//metod sözdizimi (akıcı söz dizimi olarak bilinir), herhangi bir sınıfın metotlarını nasıl çağıracağımıza benzer şekilde enumerable ve ya queryable statik sınıfında bulunan metotları kullanarak sorgular geliştirdiğimiz komutlardır
//derleyici, derleme zamanında query sözdizimini metot sözdizimine dönüştürür
//metot sözdizimi, metot ve lambda ifadesinden oluşmaktadır.

// select*from student
var result5 = studentList.ToList();
foreach (var item in result5)
{
    Console.WriteLine($"Method Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}

Console.WriteLine(new String('*', 30));
// select studentid,studentname from student
var result6 = studentList.Select(s=>new {s.studentID,s.studentName});
foreach (var item in result6)
{
    Console.WriteLine($"Method Syntax Id: {item.studentID} Name: {item.studentName} ");
}

Console.WriteLine(new String('+', 30));

//select * from student order by studentname asc
var result7 = studentList.OrderBy(s => s.studentName).ToList();
foreach (var item in result7)
{
    Console.WriteLine($"Method Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}

Console.WriteLine(new String('+', 30));
//select * from student order by studentname desc
var result8 = studentList.OrderByDescending(s => s.studentName).ToList();
foreach (var item in result8)
{
    Console.WriteLine($"Method Syntax Id: {item.studentID} Name: {item.studentName} Age: {item.Age} ");
}

#endregion