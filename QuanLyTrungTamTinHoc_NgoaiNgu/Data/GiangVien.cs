using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class GiangVien
    {
        public int ID { get; set; }
        public string MaSo { get; set; }
        public string HoVaTen { get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string? Sdt { get; set; }
        public string? DiaChi { get; set; }
        public string? Email { get; set; }
        public string? HinhAnh { get; set; } 
        public string? BoPhan { get; set; }
        public int TaiKhoanID { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; } = null!;
        public virtual ObservableCollectionListSource<LichHoc> LichHoc { get; } = new();
    }
}
