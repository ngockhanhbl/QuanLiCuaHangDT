namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLHOADON")]
    public partial class QLHOADON
    {
        [Key]
        [StringLength(100)]
        public string maHoaDon { get; set; }

        public DateTime? ngayLapHoaDon { get; set; }

        public double? thanhTien { get; set; }

        public virtual HOADON HOADON { get; set; }
    }
}
