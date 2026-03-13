using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class KhoaHoc
    {
        public int ID { get; set; }
        public string TenKhoaHoc { get; set; }
        public int HocPhi { get; set; }
        public int ThoiLuong { get; set; }

        public virtual ObservableCollectionListSource<LopHoc> LopHoc { get; } = new();

        public int SoLopDangMo
        {
            get
            {
                return LopHoc.Count(x => x.TrangThai);
            }
        }
    }
}
