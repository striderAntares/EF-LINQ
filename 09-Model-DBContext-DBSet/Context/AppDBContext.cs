using _09_Model_DBContext_DBSet.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Model_DBContext_DBSet.Context
{
    internal class AppDBContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15BookStore;Integrated Security=True;TrustServerCertificate=True");
        }//classın dışına çıkma talu
    }//build failed veriyosa bu başka bir yerde hata olduğuna delalet olabilir.

        /*
        * 1- Entity Sınıflarımızı yazıyoruz
        * 2- Context sınıfımızı oluşturuyoruz
        * 3- Context sınıfımızı DbContext'ten miras alıyoruz
        * 4- DbContext için EntityFrameWorkCore u nugetten indiriyoruz.
        * 5-) Context sınıfı içine DbSet ile veritabanında oluşmasını istediğimiz entity sınıflarımızı yazıyoruz.
        * 6-) Context sınıfı içine OnConfiguring metodunu override edip Connection cümlemizi yazıyoruz.
        * 7-) UseSqlServer için EntityFramewokCore.SqlServer'ı nugetten yüklüyoruz
        * 8-) EntityFrameWorkCore.Tools'u nugetten yüklüyoruz.
        * 9-) Package Manager Console (here on PMC)> add-migration migrationName yazıyoruz migration için.
        * 10-) PMC> update-database veritabanındaki değişikliği bu yapıyor.
        */
}
