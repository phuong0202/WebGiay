using CleanArchitecture.Domian.Models;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Data.Context
{
    public partial class WebEnglishDBContext : DbContext
    {
        public WebEnglishDBContext()
        {
        }

        public WebEnglishDBContext(DbContextOptions<WebEnglishDBContext> options)
            : base(options)
        {
        }

        
        public virtual DbSet<HoaDon> HoaDon { get; set; }
        public virtual DbSet<KhachHang> KhachHang { get; set; }
        public virtual DbSet<SanPham> SanPham { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source =.; Initial Catalog = WebDB; Integrated Security=False; User Id=sa; Password=123456; MultipleActiveResultSets=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<HoaDon>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdKhachHang).HasColumnName("IDKhachHang");

                entity.Property(e => e.Ngay)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdKhachHangNavigation)
                    .WithMany(p => p.HoaDon)
                    .HasForeignKey(d => d.IdKhachHang)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("NguoiDung_HoaDon");
            });

            modelBuilder.Entity<KhachHang>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatKhau)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sdt)
                    .HasColumnName("SDT")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaiKhoan)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenKhachHang).HasMaxLength(100);

                entity.Property(e => e.VaiTro).HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<SanPham>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Hinh)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SoLuong)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.TenLoai)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TenSanPham).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
            
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
