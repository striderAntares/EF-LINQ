using _18_NtierMapping.DATA;
using _18_NTierMapping.DAL.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_NTierMapping.DAL
{
    public class AppDbContext : DbContext //DATA tierin dlli eklemeden önce sınıfların public olduğundan emin ol. eklemek için eklemek istediğin projeye gir ters tıkla add -> project reference de ve seç.
    {
        public DbSet<Film> Filmler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //}
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Film>().Property(f => f.FilmAdi).IsRequired();

        //    modelBuilder.Entity<Film>().ToTable("Filmler");

        //    //Film tablo ile FilmKategori tablosu 1e çok ilişkili. Film.csdeki kategoriID property'si ise FK olmalı!

        //    modelBuilder.Entity<Film>().HasOne(f => f.FilminKategorisi).WithMany(fk => fk.KategorininFilmleri).HasForeignKey(r => r.KategoriID);

        //    //Kategori FluentAPI
        //    //Oyuncu FluentAPI
        //    //FilmDetayAPI
        //    //Çok uzadığı için mevzu ayrı sınıflara böleceğiz mapping yapacağız.
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new FilmMapping().Configure(modelBuilder.Entity<Film>());
            new FilmDetayMapping().Configure(modelBuilder.Entity<FilmDetay>());
            new OyuncuMapping().Configure(modelBuilder.Entity<Oyuncu>());
            //IEntityTypeConfiguration interfaceinden miras aldırıp kurduğumuz fluent api classları ile appdbcontext arasında bağı bu satırlarla sağlamış olduk.
            base.OnModelCreating(modelBuilder);
        }
    }
}
