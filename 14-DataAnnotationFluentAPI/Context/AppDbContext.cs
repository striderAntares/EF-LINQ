using _14_DataAnnotationFluentAPI.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_DataAnnotationFluentAPI.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15DataAnnotations;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Column
            modelBuilder.Entity<Book>().Property(b => b.Title).HasColumnName("Description").HasColumnType("nvarchar(50)").HasColumnOrder(2);//data annotation kullanmadan fluent apida böyle yapılır.

            //DatabaseGenerated
            modelBuilder.Entity<Contact>().Property(c => c.LastAccessed).ValueGeneratedOnAddOrUpdate();
            modelBuilder.Entity<Contact>().Property(c => c.CreationDate).ValueGeneratedOnAdd();

            //ForeignKey
            modelBuilder.Entity<Book>().HasOne(b => b.Author).WithMany(b => b.Books).HasForeignKey(e => e.AuthorFk); //foreign key ataması için önce bağı kurmak gerekiyor.
            //key
            modelBuilder.Entity<Order>().HasKey(o => o.OrderNumber); //primary böyle veriliyor.

            //Composite Keys
            //modelBuilder.Entity<Order>().HasKey(o=> new { o.CustomerAbbreviation, o.OrderNumber});

            //MaxLength

            //modelBuilder.Entity<Book>().Property(b => b.Title).HasMaxLength(150);

            //NotMapped-Entity
            modelBuilder.Ignore<AuditLog>();
            //NotMapped-Property
            modelBuilder.Entity<Contact>().Ignore(c => c.AuditLog);

            //Required
            modelBuilder.Entity<Book>().Property(b => b.Title).IsRequired();//not nullable
            //Table Attribute
            modelBuilder.Entity<Book>().ToTable("tbl_Book");//veri tabanında nasıl gözükeceğini yazar.


            base.OnModelCreating(modelBuilder);
        }
    }
}
