using _17_UrunEklemeOtomasyon.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_UrunEklemeOtomasyon.Context
{
    //Aşağıdaki property'ler oluşacak DB'de yer almasını istediğimiz tabloları temsil eden Class'lardan oluşur. Buraya eklenmeyen Class, DB'ye de tablo olarak gitmez. Aynı zamanda, buradaki property isimleri KESİNLİKLE tablo isimleri değil, uygulamada DB'deki tablolara ulaşırken kullanacak property isimleridir.
    // BaseEntity, bizim için ortak property'leri tuttuğumuz bir class olduğundan burada tablo oluşturmasını istemediğimiz için yazmıyoruz!

    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<AppUser> AppUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15DbUrunOtomasyon;Integrated Security=True;TrustServerCertificate=True");
            //optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
