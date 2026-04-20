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
                StringBuilder sb = new StringBuilder();
                sb.AppendLine($"Học viên: {hocVien.HoVaTen.ToUpper()}");
                sb.AppendLine("------------------------------------------");

                if (hocVien.KetQua.Count > 0)
                {
                    foreach (var kq in hocVien.KetQua)
                    {
                        string tenLop = kq.LopHoc != null ? kq.LopHoc.TenLopHoc : "(Lớp không xác định)";
                        string diemThu = kq.DiemThiThu.HasValue ? kq.DiemThiThu.Value.ToString() : "Chưa có";
                        string diemThat = kq.DiemThiThat.HasValue ? kq.DiemThiThat.Value.ToString() : "Chưa có";

                        sb.AppendLine($"Lớp: {tenLop}");
                        sb.AppendLine($"- Điểm thi thử: {diemThu}");
                        sb.AppendLine($"- Điểm thi thật: {diemThat}");
                        sb.AppendLine(""); 
                    }
                }
                else
                {
                    sb.AppendLine("Học viên này hiện chưa được xếp lớp nào.");
                }

                lblHienThi.Text = sb.ToString();
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
