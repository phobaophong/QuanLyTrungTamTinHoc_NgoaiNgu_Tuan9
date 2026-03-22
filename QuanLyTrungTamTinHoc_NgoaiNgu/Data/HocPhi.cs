using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class HocPhi
    {
        public int ID { get; set; }
        public int HocVienID { get; set; }
        public int LopHocID { get; set; }
        public decimal SoTienDaDong { get; set; }
        public bool TrangThai { get; set; } 
        public DateTime NgayDong { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LopHoc LopHoc { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachHocPhi_ChiTiet
    {
        public int ID { get; set; }
        public int HocVienID { get; set; }
        public string? HoVaTen { get; set; }
        public int LopHocID { get; set; }
        public string? TenLop {  get; set; }
        public decimal SoTienDaDong { get; set; }
        public DateTime NgayDong { get; set; }
        public string? GhiChu { get; set; }
    }
}
