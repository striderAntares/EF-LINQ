using _13_RelationshipEFCORE.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _13_RelationshipEFCORE.Context
{
    internal class AppDBContextRelationship : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseLazyLoadingProxies(); //bu ürünlerden kategori isimlerini direk çekmemize yarıyacak. bu metodu çağırabilmek için entity framework proxies paketini indirdik nugetten. sınıflarda bulunan bütün navigasyon öğelerini virtual olarak istiyor.
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15Relationship;Integrated Security=True;TrustServerCertificate=True");//con string
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one to many
            modelBuilder.Entity<Product>().HasOne(p => p.Category).WithMany(p => p.Products).HasForeignKey(p => p.CategoryRefID);
            //one to one
            modelBuilder.Entity<Product>().HasOne(p => p.ProductDetail).WithOne(p => p.Product).HasForeignKey<ProductDetail>(p => p.ProductRefID);
            base.OnModelCreating(modelBuilder);

        }
    }
}
