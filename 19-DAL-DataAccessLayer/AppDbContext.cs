using _19_DAL_DataAccessLayer.Mapping;
using _19_DATA;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _19_DAL_DataAccessLayer
{
    public class AppDbContext : DbContext
    {
        public DbSet<Personnel> Personnels { get; set; }
        public DbSet<ContactInfo> ContactInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new PersonnelMapping().Configure(modelBuilder.Entity<Personnel>());
            new ContactInfoMapping().Configure(modelBuilder.Entity<ContactInfo>());
            base.OnModelCreating(modelBuilder);

            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15N-TierArch;Integrated Security=True;TrustServerCertificate=True");
        }
    }
}
