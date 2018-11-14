namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            nhapKhoes = new HashSet<nhapKho>();
            XUATKHOes = new HashSet<XUATKHO>();
        }

        [Key]
        [StringLength(100)]
        public string maSanPham { get; set; }

        [StringLength(100)]
        public string tenSanPham { get; set; }

        public byte[] Images { get; set; }

        [StringLength(100)]
        public string MaNhaCC { get; set; }

        [StringLength(100)]
        public string ProductTypeID { get; set; }

        public virtual CHITIETSANPHAM CHITIETSANPHAM { get; set; }

        public virtual LoaiSanPham LoaiSanPham { get; set; }

        public virtual NhaCungCap NhaCungCap { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<nhapKho> nhapKhoes { get; set; }

        public virtual TONKHO TONKHO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<XUATKHO> XUATKHOes { get; set; }
    }
}
