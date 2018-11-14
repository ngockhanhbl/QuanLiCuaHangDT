namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("nhapKho")]
    public partial class nhapKho
    {
        [StringLength(100)]
        public string id { get; set; }

        [StringLength(100)]
        public string maSanPham { get; set; }

        public int? soLuong { get; set; }

        public DateTime? ngayNhap { get; set; }

        public int? TrangThai { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
