using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class KetQua
    {
        public int ID { get; set; }
        public int HocVienID { get; set; }
        public int LopHocID { get; set; }
        public float? DiemThiThu { get; set; }
        public float? DiemThiThat { get; set; }

        public virtual HocVien HocVien { get; set; } = null!;
        public virtual LopHoc LopHoc { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachDiemSo_ChiTiet
    {
        public int ID { get; set; }
        public int HocVienID { get; set; }
        public string MaSo { get; set; }
        public string HoVaTen { get; set; }
        public int LopHocID { get; set; }
        public string TenLop { get; set; }
        public float? DiemThiThu { get; set; }
        public float? DiemThiThat { get; set; }
    }

}
