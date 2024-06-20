using _15_EFLiveExcersize.Context;
using _15_EFLiveExcersize.Entities;

var context = new AppDbContext();



//#region Update
//School sch = new School()
//{
//    Name = "MephI",

//};


//Student stu = new Student()
//{
//    Name = "Huseyin Talo",
//    Age = 29,
//    SchoolNo = 1

//};

//context.Schools.Add(sch);
//context.Students.Add(stu);

//context.SaveChanges();
//#endregion

#region Read
Student st = context.Students.Find(1);
Console.WriteLine($"Name: {st.Name}");
#endregion

//#region Delete
//Student str = context.Students.Find(1);
//context.Remove<Student>(str);
//context.SaveChanges();
//#endregion
