using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class LoaiDiem
    {
        public int ID { get; set; }
        public string TenLoaiDiem { get; set; }
        public float HeSo { get; set; }

        public virtual ObservableCollectionListSource<KetQua> KetQua { get; } = new();
    }
}
