using _06_LinqQueryOperators;
using System.Linq;

IList<Person> studentList = new List<Person>()
{
    new Person() {studentID = 1, studentName = "John", Age = 18},
    new Person() {studentID = 2, studentName ="Steve", Age=15},
    new Person() {studentID = 3, studentName ="Bill", Age=25 },
    new Person() {studentID = 4, studentName = "Ram", Age = 20},
    new Person() {studentID = 5, studentName = "Ron", Age = 19}
};

#region Where
//query syntax
var where1 = from s in studentList where s.Age > 12 && s.Age < 20 select s;

foreach (var item in where1)
{
    Console.WriteLine($"{item.studentID} {item.studentName} {item.Age}");
}
//metot syntax
var where2 = studentList.Where(s => s.Age > 12 && s.Age < 20);
#endregion

#region OrderBy
//orderby artan ve ya azalan
//select*from studentslist order by personname asc

//query syntax
var orderby1 = from s in studentList orderby s.studentName ascending select s; //asc default gerek yok yazmağa

var orderby1desc = from s in studentList orderby s.studentName descending select s;
//method syntax
var orderby2 = studentList.OrderBy(s => s.studentName);
var orderby2desc = studentList.OrderByDescending(s => s.studentName);
#endregion

#region GroupBy
//groupby bazı anahtar değerleri temel alarak verilen koleksiyondan bir grup öğe döndürür

//select*from studentList group by Age
//query syntax

var groupBy1 = from s in studentList group s by s.Age;

//method syntax

var groupBy2 = studentList.GroupBy(s => s.Age);
#endregion

#region Any
//Any, herhangi bir elemanın verilen koşulu sağlayıp sağlamadığını kontrol eder. sadece methodda var.
//Method Syntax
bool any1 = studentList.Any(s => s.studentName == "Cemil"); //cemil olabilir mi cemil?
#endregion

#region Contains
//contains, koleksiyonda belirtilen bir öğenin var olup olmadığını kontrol eder ve bir boole dönüştürür.
Person prsn = new Person() { studentID = 3, studentName = "Suat", Age = 6000 };

bool contains1 = studentList.Contains(prsn); //Suat olabilir mi?

#endregion

#region Average
//Method syntax
var avg = studentList.Average(s => s.Age);
#endregion

#region Count
//Count, koleksiyondaki öğelerin sayısını veya verilen koşulu sağlayan öğelerin sayısını döndürür

//Method Syntax

var count = studentList.Count();
#endregion

#region MaxMin
//Method syntax
var max = studentList.Max(s => s.Age);
var min = studentList.Min(s => s.Age);
#endregion


#region Sum
//sum toplar
//method syntax
var sum = studentList.Sum(s => s.Age);
#endregion

#region Take
//Take, ilk öğeden başlayarak belirtilen sayıda öğreyi döndürür.
//TakeWhile, belirtilen koşul doğru olana kadar öğreleri döndürür.
//Method Syntax
var take = studentList.Take(3);
var takeWhile = studentList.TakeWhile(s => s.studentName == "John");
Console.WriteLine(new String('*', 30));
foreach (var item in takeWhile)
{
    Console.WriteLine($"{item.studentID} {item.studentName} {item.Age}");
}


#endregion

Console.WriteLine(new String('*', 30));
#region Skip
//skip, ilk öğreden başlayarak belirtilen sayıda öğreyi atlar ve geri kalan öğreleri döndürür
//SkipWhile, belirtilen koşul doğru olana kadar koleksiyondaki öğeleri atlar.
//Method Syntax
var skip = studentList.Skip(3);
foreach (var item in skip)
{
    Console.WriteLine(item.studentName);
}
//mesela sahibindende itemler sıralanırken 2. sayfayı açtık ilk 20 itemi skip et sonraki 20yi take et. işten çıkarken cuma günü patrona am günü yağ.

var skipWhile = studentList.SkipWhile(s => s.studentName == "Ram");
#endregion

#region FirstOrDefault
//first, bir koleksiyonun ilk öğesini ve ya bir koşulu sağlayan ilk öğeyi döndürür.
//firstordefault, bir koleksiyonun ilk öğesini ve ya bir koşulu karşılayan ilk öğeyi döndürür, eğer indeks aralığın dışındaysa varsayılan bir değer döndürür.

//method syntax
//var first = studentList.First();
//var first2 = studentList.First(s => s.studentName == "Billy");
//var firstOrDefault = studentList.FirstOrDefault();
//var firstOrDefault2 = studentList.FirstOrDefault(s => s.studentName == "Billy"); //reference type olduğu için null döner default olarak ondan sonra onu kontrol ederiz (non nullable olanlar için 0 döndürür - aka value type ya da non nullable işaretli) null mı değil mi diye işlemleri öyle yaptırırız ve böylece güvenceye almış oluruz firste göre yeğdir.
#endregion

#region LastOrDefault
//Last; bir koleksiyondaki son öğeyi ve ya bir koşulu sağlayan son öğeyi döndüdür. hiç bir öğe bulamazsa istisna atar. throwing exception.
//LastOrDefault; bir koleksiyondaki son öğeyi ve ya bir koşulu sağlayan son öğeyi döndürür, bulamazsa default bir öğe döndürür.
//var last = studentList.Last();
//var last2 = studentList.Last(s => s.studentName == "Billy");
//var lastOrDefault = studentList.LastOrDefault();
//var lastOrDefault2 = studentList.LastOrDefault(s => s.studentName == "Billy");

#endregion

#region SingleSingleOrDefault
//Single Bir koleksiyondaki tek öğeyi ve ya bir koşulu karşalayan tek öğeyi döndürür.Single(), koleksiyonda hiçbir öğe ve ya birden fazla öğe bulamazsa, InvalidOperationException hatası verir.

//Method Syntax
//var single1 = studentList.Single();
//var single2 = studentList.Single(s => s.studentName == "Steve");

//var single3 = studentList.SingleOrDefault();
//var single4 = studentList.SingleOrDefault(s => s.studentName == "Steve");
#endregion


#region Join
//Join operatörü, inner collection ve outer collection olmak üzere iki collection üzerinde çalışır. Belirtilen ifadeyi karşılayan her iki collection'dan öğeler içeren yeni bir collection döndürür.

IList<StudentForJoin> studentListto = new List<StudentForJoin>() {
    new StudentForJoin() { StudentID = 1, StudentName = "John", StandardID =1 },
    new StudentForJoin() { StudentID = 2, StudentName = "Moin", StandardID =1 },
    new StudentForJoin() { StudentID = 3, StudentName = "Bill", StandardID =2 },
    new StudentForJoin() { StudentID = 4, StudentName = "Ram" , StandardID =2 },
    new StudentForJoin() { StudentID = 5, StudentName = "Ron"  }
};

IList<StandartForJoin> standardList = new List<StandartForJoin>() {
    new StandartForJoin(){ StandardID = 1, StandardName="Standard 1"},
    new StandartForJoin(){ StandardID = 2, StandardName="Standard 2"},
    new StandartForJoin(){ StandardID = 3, StandardName="Standard 3"}
};

//Method Syntax
var innerJoin1 = studentListto.Join // outer collection
( 
    standardList, //inner collection
    student => student.StandardID, //outer key selector
    standard => standard.StandardID, //inner key selector
    (student, standard) => new
    {
        StudentName = student.StudentName,
        StandardName = standard.StandardName
    } //define the column names of the newly created
 );
Console.WriteLine("InnerJo: ");
foreach (var item in innerJoin1)
{
    Console.WriteLine($"Student Name: {item.StudentName} Standard Name: {item.StandardName}" );
}

Console.WriteLine(new String('*', 30));
//Query Syntax
var innerJoin2 = from s in studentListto // outer
                 join st in standardList //inner collection
                 on s.StandardID equals st.StandardID // key selector
                 select new
                 { //result selector
                 StudentName = s.StudentName,
                 StandardName = st.StandardName
                 };
Console.WriteLine("InnerJoQuery: ");
foreach (var item in innerJoin2)
{
    Console.WriteLine($"Student Name: {item.StudentName} Standard Name: {item.StandardName}");
}
#endregion