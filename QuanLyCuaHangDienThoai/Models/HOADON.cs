namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HOADON")]
    public partial class HOADON
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HOADON()
        {
            KHACHHANGs = new HashSet<KHACHHANG>();
        }

        [Key]
        [StringLength(100)]
        public string maHoaDon { get; set; }

        [StringLength(100)]
        public string maSanPham { get; set; }

        [StringLength(100)]
        public string tenSanPham { get; set; }

        public int? soLuong { get; set; }

        public double? donGia { get; set; }

        public double thanhTien { get; set; }

        [StringLength(100)]
        public string maNhanVien { get; set; }

        public DateTime ngayLapHoaDon { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHACHHANG> KHACHHANGs { get; set; }

        public virtual QLHOADON QLHOADON { get; set; }
    }
}
