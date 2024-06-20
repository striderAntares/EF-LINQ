using _15_EFLiveExcersize.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _15_EFLiveExcersize.Context
{
    internal class AppDbContext : DbContext
    {
        public DbSet<Laptop> Laptops { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<School> Schools { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=HS-15DataLiveExerciseFluentAPI;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //primary keys
            modelBuilder.Entity<Student>().HasKey(e => e.StudentNo);
            modelBuilder.Entity<Laptop>().HasKey(e => e.Id);
            modelBuilder.Entity<StudentDetail>().HasKey(e => e.SDId);
            modelBuilder.Entity<Lesson>().HasKey(r => r.LessonNo);
            //foreign keys
            modelBuilder.Entity<Student>(entity => entity.HasOne(s => s.School).WithMany(t => t.Students).HasForeignKey(f => f.SchoolNo));
            modelBuilder.Entity<Laptop>(entity => entity.HasOne(e => e.Student).WithOne(l => l.Laptop).HasForeignKey<Student>(r => r.StudentNo));
            modelBuilder.Entity<StudentDetail>().HasOne(e => e.Student).WithOne(s => s.StudentDetail).HasForeignKey<Student>(r => r.StudentNo);
            modelBuilder.Entity<Department>().HasMany(e => e.Schools).WithMany(s => s.Departments);
            modelBuilder.Entity<Lesson>().HasOne(d => d.Department).WithMany(l => l.Lessons).HasForeignKey(r => r.DepartmentId);
            //nonmapped
            //modelBuilder.Entity<Student>().Ignore(c => c.Laptop);
            //modelBuilder.Entity<Student>().Ignore(c => c.StudentDetail);
            //table names
            modelBuilder.Entity<School>().ToTable("Okul");
            modelBuilder.Entity<School>().Property(p => p.Name).HasColumnName("Okul adi");


            base.OnModelCreating(modelBuilder);
        }
    }
}
