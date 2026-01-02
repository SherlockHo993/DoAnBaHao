using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Model
{
    public partial class QLHVContextDB : DbContext
    {
        public QLHVContextDB()
            : base("name=QLHVConetxtDB")
        {
        }

        public virtual DbSet<BIENLAI> BIENLAIs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<HOCVIEN> HOCVIENs { get; set; }
        public virtual DbSet<LOPHOC> LOPHOCs { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.MALH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.MAHV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.DIEM)
                .HasPrecision(3, 1);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.XEPLOAI)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<BIENLAI>()
                .Property(e => e.TIENNOP)
                .HasPrecision(12, 0);

            modelBuilder.Entity<GIAOVIEN>()
                .Property(e => e.MAGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCVIEN>()
                .Property(e => e.MAHV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HOCVIEN>()
                .HasMany(e => e.BIENLAIs)
                .WithRequired(e => e.HOCVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOPHOC>()
                .Property(e => e.MALH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOC>()
                .Property(e => e.MAMH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOC>()
                .Property(e => e.MAGV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOC>()
                .Property(e => e.PHHOC)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LOPHOC>()
                .HasMany(e => e.BIENLAIs)
                .WithRequired(e => e.LOPHOC)
                .WillCascadeOnDelete(false);
        }
    }
}
