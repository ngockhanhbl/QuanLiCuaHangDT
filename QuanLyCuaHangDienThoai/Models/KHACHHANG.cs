namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHACHHANG")]
    public partial class KHACHHANG
    {
        [Key]
        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(100)]
        public string tenKhachHang { get; set; }

        [StringLength(100)]
        public string diaChi { get; set; }

        [StringLength(100)]
        public string maHoaDon { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
