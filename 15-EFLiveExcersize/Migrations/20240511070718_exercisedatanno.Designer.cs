﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _15_EFLiveExcersize.Context;

#nullable disable

namespace _15_EFLiveExcersize.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240511070718_exercisedatanno")]
    partial class exercisedatanno
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DepartmentSchool", b =>
                {
                    b.Property<int>("DepartmentsDepartmentId")
                        .HasColumnType("int");

                    b.Property<int>("SchoolsSchoolId")
                        .HasColumnType("int");

                    b.HasKey("DepartmentsDepartmentId", "SchoolsSchoolId");

                    b.HasIndex("SchoolsSchoolId");

                    b.ToTable("DepartmentSchool");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Laptop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("StudentNo")
                        .IsUnique();

                    b.ToTable("Laptops");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Lesson", b =>
                {
                    b.Property<int>("LessonNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LessonNo"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("LessonNo");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.School", b =>
                {
                    b.Property<int>("SchoolId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SchoolId"));

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Okul Adi");

                    b.Property<int>("StudentNo")
                        .HasColumnType("int");

                    b.HasKey("SchoolId");

                    b.ToTable("Okul");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Student", b =>
                {
                    b.Property<int>("StudentNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentNo"));

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SchoolNo")
                        .HasColumnType("int");

                    b.HasKey("StudentNo");

                    b.HasIndex("SchoolNo");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.StudentDetail", b =>
                {
                    b.Property<int>("SDId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SDId"));

                    b.Property<string>("Detail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentNo")
                        .HasColumnType("int");

                    b.HasKey("SDId");

                    b.HasIndex("StudentNo")
                        .IsUnique();

                    b.ToTable("StudentDetails");
                });

            modelBuilder.Entity("DepartmentSchool", b =>
                {
                    b.HasOne("_15_EFLiveExcersize.Entities.Department", null)
                        .WithMany()
                        .HasForeignKey("DepartmentsDepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_15_EFLiveExcersize.Entities.School", null)
                        .WithMany()
                        .HasForeignKey("SchoolsSchoolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Laptop", b =>
                {
                    b.HasOne("_15_EFLiveExcersize.Entities.Student", "Student")
                        .WithOne("laptop")
                        .HasForeignKey("_15_EFLiveExcersize.Entities.Laptop", "StudentNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Lesson", b =>
                {
                    b.HasOne("_15_EFLiveExcersize.Entities.Department", "Department")
                        .WithMany("Lessons")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Student", b =>
                {
                    b.HasOne("_15_EFLiveExcersize.Entities.School", "School")
                        .WithMany("Students")
                        .HasForeignKey("SchoolNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("School");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.StudentDetail", b =>
                {
                    b.HasOne("_15_EFLiveExcersize.Entities.Student", "Student")
                        .WithOne("StudentDetail")
                        .HasForeignKey("_15_EFLiveExcersize.Entities.StudentDetail", "StudentNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Department", b =>
                {
                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.School", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("_15_EFLiveExcersize.Entities.Student", b =>
                {
                    b.Navigation("StudentDetail")
                        .IsRequired();

                    b.Navigation("laptop")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}