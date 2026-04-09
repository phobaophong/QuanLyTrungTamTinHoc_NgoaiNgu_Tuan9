using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class LopHoc
    {
        public int ID { get; set; }
        public string TenLopHoc { get; set; }
        public DateTime NgayBatDau { get; set; }
        public DateTime NgayKetThuc { get; set; }
        public bool TrangThai { get; set; }
        public int SiSo { get; set; }
        public int KhoaHocID { get; set; }

        public virtual KhoaHoc KhoaHoc { get; set; } = null!;
        public virtual ObservableCollectionListSource<LichHoc> LichHoc { get; } = new();
        public virtual ObservableCollectionListSource<KetQua> KetQua { get; } = new();
        public virtual ObservableCollectionListSource<HocPhi> HocPhi { get; } = new();

        public int SiSoThucTe
        {
            get
            {
                if (HocPhi != null)
                {
                    return HocPhi.Count;
                }
                return 0;
            }
        }
    }
}
