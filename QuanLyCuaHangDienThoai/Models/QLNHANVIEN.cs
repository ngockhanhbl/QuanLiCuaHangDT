namespace QuanLyCuaHangDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QLNHANVIEN")]
    public partial class QLNHANVIEN
    {
        [Required]
        [StringLength(100)]
        public string chucVu { get; set; }

        public double? luong { get; set; }

        [Required]
        [StringLength(100)]
        public string tenChucVu { get; set; }

        [Key]
        [StringLength(100)]
        public string MaNV { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
