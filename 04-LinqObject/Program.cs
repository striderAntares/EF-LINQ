using _04_LinqObject;
using System.Text;

string[] dersler = { "Matematik", "Türkçe", "Fen Bilgisi", "Beden Eğitimi", "Müzik", "Tarih" };

//LinQ to Objects
// select * from Dersler

var dersList = from x in dersler select x;

StringBuilder stringBuilder = new StringBuilder();

foreach (var item in dersList )
{
    stringBuilder.Append( item + "\t" ); //yazi += bi farkı yok yeni bir metod.
}

// \t: Tab, \n: yeni satır

Console.WriteLine( stringBuilder.ToString() );

List<Personnel> personnelList = new List<Personnel>() 
{
    new Personnel(){Id = 1, Adi="Huseyin",Soyadi="Talo",Maasi=53000 },
    new Personnel(){Id = 2, Adi="Huseyinn",Soyadi="Talo",Maasi=100000 },
    new Personnel(){Id = 3, Adi="Huseyinnn",Soyadi="Talo",Maasi=150000 },
    new Personnel(){Id = 4, Adi="Huseyinnnn",Soyadi="Talo",Maasi=175000 },

};

personnelList.Add(new Personnel() { Id = 5, Adi = "Hüseyinnnnn", Soyadi = "Talo", Maasi = 200000 });

Personnel prsn = new Personnel();
prsn.Id = 6;
prsn.Adi = "Hüseyinnnnnn";
prsn.Soyadi = "Talo";
prsn.Maasi = 225000;

personnelList.Add(prsn);

var personneller = from p in personnelList select p; //pden peyi seçmek ne demek amk.


var persons = from p in personnelList select p; //burayı tamamla sonra koşullarını

foreach (var kisi in personneller)
{
    Console.WriteLine($"PersonelID:  {kisi.Id} Name: {kisi.Adi}  Surname: {kisi.Soyadi} Wage: {kisi.Maasi}");
}


