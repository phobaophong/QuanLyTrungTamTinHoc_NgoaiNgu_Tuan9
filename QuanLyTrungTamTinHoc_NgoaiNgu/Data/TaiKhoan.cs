using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Data
{
    public class TaiKhoan
    {
        public int ID { get; set; }
        public string TenDN { get; set; }
        public string MatKhau { get; set; }
        public bool TrangThai { get; set; } 
        public int QuyenHan { get; set; }

        public virtual ObservableCollectionListSource<HocVien> HocVien { get; } = new();
        public virtual ObservableCollectionListSource<GiangVien> GiangVien { get; } = new();
        public virtual ObservableCollectionListSource<NhanVien> NhanVien { get; } = new();
    }
}
