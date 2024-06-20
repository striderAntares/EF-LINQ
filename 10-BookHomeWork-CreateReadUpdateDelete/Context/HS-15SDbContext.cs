using _10_StudentsHomeWork_CreateReadUpdateDelete.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_StudentsHomeWork_CreateReadUpdateDelete.Context
{
    internal class HS_15SDbContext : DbContext
    {
        public DbSet<Field> Fields { get; set; }
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15StudentDB;Integrated Security=True;TrustServerCertificate=True");//con string
        }

        
        
    }
}
