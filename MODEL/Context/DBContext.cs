using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using hoangdhph31492_Csharp3_BT2._2.MODEL.DomainClass;

namespace hoangdhph31492_Csharp3_BT2._2.MODEL.Context;

public partial class DBContext : DbContext
{
    public DBContext()
    {
    }

    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Nxb> Nxbs { get; set; }

    public virtual DbSet<Sach> Saches { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ADMIN;Initial Catalog=FINALASS_FPOLY_NET_JAVA_SM22_BL2_2;Integrated Security=True;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Nxb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__NXB__3214EC07097057A5");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Sach>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Sach__3214EC074101C96D");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.IdNxbNavigation).WithMany(p => p.Saches).HasConstraintName("FK_Sach_NXB");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
