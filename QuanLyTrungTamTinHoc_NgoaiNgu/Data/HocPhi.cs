using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class HocPhi
    {
        public int ID { get; set; }
        public int HocVienID { get; set; }
        public int LopHocID { get; set; }
        public int SoTienDaDong { get; set; }
        public bool TrangThai { get; set; } 
        public DateTime NgayDong { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LopHoc LopHoc { get; set; } = null!;
    }
}
