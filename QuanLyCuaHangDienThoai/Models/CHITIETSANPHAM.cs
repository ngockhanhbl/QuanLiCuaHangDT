namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETSANPHAM")]
    public partial class CHITIETSANPHAM
    {
        [Key]
        [StringLength(100)]
        public string maSanPham { get; set; }

        public double? donGiaNhap { get; set; }

        public double? donGiaXuat { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
