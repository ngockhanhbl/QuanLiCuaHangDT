namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TONKHO")]
    public partial class TONKHO
    {
        [Key]
        [StringLength(100)]
        public string maSanPham { get; set; }

        public int soLuong { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
