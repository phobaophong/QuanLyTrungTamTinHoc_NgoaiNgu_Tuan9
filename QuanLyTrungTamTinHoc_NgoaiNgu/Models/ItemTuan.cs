using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Models
{
    public class ItemTuan
    {
        public int SoTuan { get; set; }
        public DateTime TuNgay { get; set; }
        public DateTime DenNgay { get; set; }
        public string TenHienThi => $"Tuần {SoTuan} [{TuNgay:dd/MM/yyyy} -- Đến {DenNgay:dd/MM/yyyy}]";
    }
}
