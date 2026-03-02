using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class NhanVien
    {
        public int ID { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? HinhAnh { get; set; } 
        public int TaiKhoanID { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
    }
}
