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
using static ReaLTaiizor.Drawing.Poison.PoisonPaint.ForeColor;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyKhoaHoc : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bindingSource = new BindingSource();
        bool temp;
        int id;
        public frmQuanLyKhoaHoc()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenKhoaHoc.Enabled = giaTri;
            txtHocPhi.Enabled = giaTri;
            txtThoiLuong.Enabled = giaTri;


            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void LoadData()
        {
            context = new QuanLyTrungTamContext();
            var kh = context.KhoaHoc.ToList();

            bindingSource.DataSource = kh;

            txtTenKhoaHoc.DataBindings.Clear();
            txtTenKhoaHoc.DataBindings.Add("Text", bindingSource, "TenKhoaHoc", false, DataSourceUpdateMode.Never);

            txtHocPhi.DataBindings.Clear();
            txtHocPhi.DataBindings.Add("Text", bindingSource, "HocPhi", false, DataSourceUpdateMode.Never);

            txtThoiLuong.DataBindings.Clear();
            txtThoiLuong.DataBindings.Add("Text", bindingSource, "ThoiLuong", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;
        }

        private void frmQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadData();
            BatTatChucNang(false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            temp = true; // thêm
            BatTatChucNang(true);

            // Xóa dữ liệu để thêm
            txtTenKhoaHoc.Clear();
            txtHocPhi.Clear();
            txtThoiLuong.Clear();
            txtTenKhoaHoc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = false; // sửa
            BatTatChucNang(true);
            txtTenKhoaHoc.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một khóa học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var khHienTai = bindingSource.Current as KhoaHoc;
            if (khHienTai == null) return;

            string canhBao = $"CẢNH BÁO CỰC ĐỘ: Bạn đang yêu cầu xóa khóa học '{khHienTai.TenKhoaHoc}'.\n\n" +
                             $"Hành động này sẽ XÓA VĨNH VIỄN:\n" +
                             $"- Tất cả các Lớp Học thuộc khóa này.\n" +
                             $"- Toàn bộ Lịch Học của các lớp đó.\n" +
                             $"- TOÀN BỘ HỌC VIÊN đang học (Bao gồm xóa Tài Khoản, Điểm Số, và Học Phí của họ).\n\n" +
                             $"Bạn có CHẮC CHẮN muốn tiêu diệt toàn bộ hệ sinh thái của khóa học này?";

            if (MessageBox.Show(canhBao, "Xác nhận Xóa Tận Gốc", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    var khoaHoc = context.KhoaHoc.Find(khHienTai.ID);
                    if (khoaHoc != null)
                    {
                        var cacLopHoc = context.LopHoc.Where(l => l.KhoaHocID == khoaHoc.ID).ToList();
                        var listIdLop = cacLopHoc.Select(l => l.ID).ToList();

                        var listIdHocVien = context.HocPhi
                                                .Where(hp => listIdLop.Contains(hp.LopHocID))
                                                .Select(hp => hp.HocVienID)
                                                .Distinct()
                                                .ToList();

                        foreach (var hvID in listIdHocVien)
                        {
                            var hv = context.HocVien.Find(hvID);
                            if (hv != null)
                            {
                                var ketQua = context.KetQua.Where(kq => kq.HocVienID == hv.ID).ToList();
                                if (ketQua.Any()) context.KetQua.RemoveRange(ketQua);

                                var hocPhi = context.HocPhi.Where(hp => hp.HocVienID == hv.ID).ToList();
                                if (hocPhi.Any()) context.HocPhi.RemoveRange(hocPhi);

                                int? idTaiKhoan = hv.TaiKhoanID;

                                context.HocVien.Remove(hv);

                                if (idTaiKhoan != null)
                                {
                                    var tk = context.TaiKhoan.Find(idTaiKhoan);
                                    if (tk != null) context.TaiKhoan.Remove(tk);
                                }
                            }
                        }

                        if (listIdLop.Any())
                        {
                            var lichHoc = context.LichHoc.Where(l => listIdLop.Contains(l.LopHocID)).ToList();
                            if (lichHoc.Any()) context.LichHoc.RemoveRange(lichHoc);

                            context.LopHoc.RemoveRange(cacLopHoc);
                        }

                        context.KhoaHoc.Remove(khoaHoc);
                        context.SaveChanges();

                        MessageBox.Show("Đã tiêu hủy sạch sẽ Khóa học cùng toàn bộ Lớp và Học viên trực thuộc!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmQuanLyKhoaHoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    string inner = ex.InnerException != null ? "\nChi tiết gốc: " + ex.InnerException.Message : "";
                    MessageBox.Show("Không thể xóa. Lỗi: " + ex.Message + inner, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhoaHoc.Text) ||
                string.IsNullOrWhiteSpace(txtHocPhi.Text) ||
                string.IsNullOrWhiteSpace(txtThoiLuong.Text))
                MessageBox.Show("Vui lòng nhập đủ thông tin khóa học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (temp)
                {
                    KhoaHoc kh = new KhoaHoc();
                    kh.TenKhoaHoc = txtTenKhoaHoc.Text;
                    kh.HocPhi = int.Parse(txtHocPhi.Text);
                    kh.ThoiLuong = int.Parse(txtThoiLuong.Text);

                    context.KhoaHoc.Add(kh);

                    context.SaveChanges();
                }
                else
                {
                    KhoaHoc kh = context.KhoaHoc.Find(id);
                    if (kh != null)
                    {
                        kh.TenKhoaHoc = txtTenKhoaHoc.Text;
                        kh.HocPhi = int.Parse(txtHocPhi.Text);
                        kh.ThoiLuong = int.Parse(txtThoiLuong.Text);
                        context.KhoaHoc.Update(kh);

                        context.SaveChanges();
                    }
                }

                frmQuanLyKhoaHoc_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyKhoaHoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
