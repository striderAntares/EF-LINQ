using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace _04_TelefonRehberiCodeFirstIntro.Models;

public partial class TelefonRehberiContext : DbContext
{
    public TelefonRehberiContext()
    {
    }

    public TelefonRehberiContext(DbContextOptions<TelefonRehberiContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Kisiler> Kisilers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-9FIH8LL;Initial Catalog=TelefonRehberi;Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Kisiler>(entity =>
        {
            entity.HasKey(e => e.KisiId).HasName("PK__Kisiler__110EDCE9CECA86A0");

            entity.ToTable("Kisiler");

            entity.Property(e => e.KisiAdi).HasMaxLength(50);
            entity.Property(e => e.KisiSoyadi).HasMaxLength(50);
            entity.Property(e => e.KisiTelefonu).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
