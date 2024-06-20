using _12_InheritanceEFCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_InheritanceEFCore.Context
{
    //table per type (TPT)
    // Bu yaklaşım, tüm kalıtım yapısını temsil etmek için veritabanında (n+1) tablo oluşturacaktır. n = subclass
    //Avantajları TPT
    //Normalize tablolar
    //kolay kolon ekleme
    //az sayıda null kolon. //onmodelcreating metodunu override edip tabloları içine vererek oluşturabiliriz.

    //table per hierarchy (TPH)
    //bu yaklaşım tüm kalıtım yapısını temsil etmek için veritabanında bir tablo oluşturacaktır. onmodelcreating metodunu override etmeden sadece dbsetleri verirsek baseperson ile birlikte TPH üretebiliriz.

    //normal bilindik yolda ise basepeople vermezsin dbsete onmodel creatingi de override etmene gerek yok.
    internal class AppDBContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<BasePerson> People { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15InheritanceEFCore;Integrated Security=True;TrustServerCertificate=True");
        }
            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //tpt üçün
            modelBuilder.Entity<Employee>().ToTable("Calisanlar");

            modelBuilder.Entity<Customer>().ToTable("Musteriler");

            base.OnModelCreating(modelBuilder);
        }
    }
}
