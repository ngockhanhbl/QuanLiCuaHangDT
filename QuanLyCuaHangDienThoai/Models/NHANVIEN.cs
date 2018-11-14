namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            HOADONs = new HashSet<HOADON>();
        }

        [Key]
        [StringLength(100)]
        public string maNhanVien { get; set; }

        [StringLength(100)]
        public string tenNhanVien { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaySinh { get; set; }

        [StringLength(10)]
        public string gioiTinh { get; set; }

        [StringLength(20)]
        public string cmnd { get; set; }

        [StringLength(11)]
        public string soDienThoai { get; set; }

        [StringLength(100)]
        public string tenDangNhap { get; set; }

        [StringLength(100)]
        public string diaChi { get; set; }

        [StringLength(100)]
        public string chucVu { get; set; }

        public virtual account account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HOADON> HOADONs { get; set; }

        public virtual QLNHANVIEN QLNHANVIEN { get; set; }
    }
}
