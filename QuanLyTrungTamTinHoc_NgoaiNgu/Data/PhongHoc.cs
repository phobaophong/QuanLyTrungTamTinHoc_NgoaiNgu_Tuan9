using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class PhongHoc
    {
        public int ID { get; set; }
        public string TenPhong { get; set; }
        public int SucChua { get; set; }

        public virtual ObservableCollectionListSource<LichHoc> LichHoc { get; } = new();
    }
}
