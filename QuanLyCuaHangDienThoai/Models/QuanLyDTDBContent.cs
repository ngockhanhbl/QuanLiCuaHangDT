namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyDTDBContent : DbContext
    {
        public QuanLyDTDBContent()
            : base("name=QuanLyDTDBContent")
        {
        }

        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<CHITIETSANPHAM> CHITIETSANPHAMs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<LoaiSanPham> LoaiSanPhams { get; set; }
        public virtual DbSet<NhaCungCap> NhaCungCaps { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<nhapKho> nhapKhoes { get; set; }
        public virtual DbSet<QLHOADON> QLHOADONs { get; set; }
        public virtual DbSet<QLNHANVIEN> QLNHANVIENs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<TONKHO> TONKHOes { get; set; }
        public virtual DbSet<XUATKHO> XUATKHOes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<account>()
                .Property(e => e.username)
                .IsUnicode(false);

            modelBuilder.Entity<account>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<account>()
                .HasMany(e => e.NHANVIENs)
                .WithOptional(e => e.account)
                .HasForeignKey(e => e.tenDangNhap);

            modelBuilder.Entity<CHITIETSANPHAM>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.maHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<HOADON>()
                .HasOptional(e => e.QLHOADON)
                .WithRequired(e => e.HOADON);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.SDT)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.maHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanPham>()
                .Property(e => e.ID)
                .IsUnicode(false);

            modelBuilder.Entity<LoaiSanPham>()
                .HasMany(e => e.SANPHAMs)
                .WithOptional(e => e.LoaiSanPham)
                .HasForeignKey(e => e.ProductTypeID);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.MaNhaCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCungCap>()
                .Property(e => e.Country)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.maNhanVien)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.cmnd)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.soDienThoai)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.tenDangNhap)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.diaChi)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.chucVu)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasOptional(e => e.QLNHANVIEN)
                .WithRequired(e => e.NHANVIEN);

            modelBuilder.Entity<nhapKho>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<nhapKho>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<QLHOADON>()
                .Property(e => e.maHoaDon)
                .IsUnicode(false);

            modelBuilder.Entity<QLNHANVIEN>()
                .Property(e => e.chucVu)
                .IsUnicode(false);

            modelBuilder.Entity<QLNHANVIEN>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.MaNhaCC)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.ProductTypeID)
                .IsUnicode(false);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.CHITIETSANPHAM)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<SANPHAM>()
                .HasOptional(e => e.TONKHO)
                .WithRequired(e => e.SANPHAM);

            modelBuilder.Entity<TONKHO>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);

            modelBuilder.Entity<XUATKHO>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<XUATKHO>()
                .Property(e => e.maSanPham)
                .IsUnicode(false);
        }
    }
}
