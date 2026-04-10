using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmTraCuuDiemThiThu : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        public frmTraCuuDiemThiThu()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maSoTimKiem = txtMaSo.Text.Trim();

            if (string.IsNullOrEmpty(maSoTimKiem))
            {
                MessageBox.Show("Vui lòng nhập mã số học viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hocVien = context.HocVien
                .Include(hv => hv.KetQua)
                .ThenInclude(kq => kq.LopHoc)
                .FirstOrDefault(hv => hv.MaSo == maSoTimKiem);

            if (hocVien != null)
            {
                var ketQua = hocVien.KetQua.FirstOrDefault();

                string hoTen = hocVien.HoVaTen;
                string tenLop = (ketQua != null && ketQua.LopHoc != null) ? ketQua.LopHoc.TenLopHoc : "(Chưa xếp lớp)";

                string diemThu = (ketQua != null && ketQua.DiemThiThu.HasValue) ? ketQua.DiemThiThu.Value.ToString() : "Chưa có điểm";
                string diemThat = (ketQua != null && ketQua.DiemThiThat.HasValue) ? ketQua.DiemThiThat.Value.ToString() : "Chưa có điểm";

                lblHienThi.Text = $"Học viên: {hoTen}\n" +
                                 $"Lớp học: {tenLop}\n" +
                                 $"Điểm thi thử: {diemThu}\n" +
                                 $"Điểm thi thật: {diemThat}";

                lblHienThi.ForeColor = Models.Utils.GiaoDien.MauChuDao; 
            }
            else
            {
                lblHienThi.Text = "Không tìm thấy học viên có mã số này!";
                lblHienThi.ForeColor = Color.Red;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
