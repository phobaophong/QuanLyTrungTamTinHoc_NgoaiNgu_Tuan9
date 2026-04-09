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
    public partial class frmQuanLyLopHoc : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bindingSource = new BindingSource();
        int id;
        bool temp;
        int quyenHanDangNhap;
        public frmQuanLyLopHoc(int quyenHan)
        {
            InitializeComponent();
            quyenHanDangNhap = quyenHan;
            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void BatTatChucNang(bool giaTri)
        {

            btnHuyBo.Enabled = giaTri;
            txtTenLopHoc.Enabled = giaTri;
            dtpNgayBatDau.Enabled = giaTri;
            dtpNgayKetThuc.Enabled = giaTri;
            rdoDaDong.Enabled = giaTri;
            rdoDangMo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;

            if (!giaTri && quyenHanDangNhap == 4)
            {
                btnXoa.Visible = true;
            }
            else
            {
                btnXoa.Visible = false;
            }
        }
        private void LoadData()
        {
            context = new QuanLyTrungTamContext();

            var lop = context.LopHoc.Include(l => l.HocPhi).ToList();

            bindingSource.DataSource = lop;

            txtTenLopHoc.DataBindings.Clear();
            txtTenLopHoc.DataBindings.Add("Text", bindingSource, "TenLopHoc", true, DataSourceUpdateMode.Never);

            dtpNgayBatDau.DataBindings.Clear();
            dtpNgayBatDau.DataBindings.Add("Value", bindingSource, "NgayBatDau", true, DataSourceUpdateMode.Never);

            dtpNgayKetThuc.DataBindings.Clear();
            dtpNgayKetThuc.DataBindings.Add("Value", bindingSource, "NgayKetThuc", true, DataSourceUpdateMode.Never);

            var current = (LopHoc)bindingSource.Current;

            if (current != null)
            {
                rdoDangMo.Checked = current.TrangThai;
                rdoDaDong.Checked = !current.TrangThai;
            }

            dataGridView.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            using (frmQuanLyLopHoc_ThemLop them = new frmQuanLyLopHoc_ThemLop(id = 0))
            {
                them.ShowDialog();
            }
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn lớp học cần sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                int idCanSua = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);

                using (frmQuanLyLopHoc_ThemLop frmSua = new frmQuanLyLopHoc_ThemLop(idCanSua))
                {
                    frmSua.ShowDialog();
                }

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form sửa: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            temp = false;
            BatTatChucNang(true);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Vui lòng chọn một lớp học để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var lopHienTai = bindingSource.Current as LopHoc;
            if (lopHienTai == null) return;

            string canhBao = $"CẢNH BÁO: Bạn đang yêu cầu xóa lớp học '{lopHienTai.TenLopHoc}'.\n\n" +
                             $"Hành động này sẽ XÓA VĨNH VIỄN:\n" +
                             $"- Toàn bộ Lịch Học của lớp này.\n" +
                             $"- TOÀN BỘ HỌC VIÊN đang học trong lớp (Bao gồm xóa Tài Khoản, Điểm Số, và Lịch sử Học Phí của họ).\n\n" +
                             $"Bạn có CHẮC CHẮN muốn xóa tận gốc lớp học này?";

            if (MessageBox.Show(canhBao, "Xác nhận Xóa Tận Gốc", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    var lopHoc = context.LopHoc.Find(lopHienTai.ID);
                    if (lopHoc != null)
                    {
                        var listIdHocVien = context.HocPhi
                                                .Where(hp => hp.LopHocID == lopHoc.ID)
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

                        var lichHoc = context.LichHoc.Where(l => l.LopHocID == lopHoc.ID).ToList();
                        if (lichHoc.Any()) context.LichHoc.RemoveRange(lichHoc);

                        context.LopHoc.Remove(lopHoc);
                        context.SaveChanges();

                        MessageBox.Show("Đã tiêu hủy sạch sẽ Lớp học và toàn bộ Học viên trực thuộc!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        frmQuanLyLopHoc_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    string inner = ex.InnerException != null ? "\nChi tiết gốc: " + ex.InnerException.Message : "";
                    MessageBox.Show("Không thể xóa. Lỗi: " + ex.Message + inner, "Lỗi SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var current = (LopHoc)dataGridView.CurrentRow.DataBoundItem;

            if (current != null)
            {
                rdoDangMo.Checked = current.TrangThai;
                rdoDaDong.Checked = !current.TrangThai;
            }
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    bool trangThai = (bool)e.Value;

                    if (trangThai)
                    {
                        e.Value = "Đang mở";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.Value = "Đã kết thúc";
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "KhoaHocID")
            {
                if (e.Value != null)
                {
                    int id = (int)e.Value;

                    var khoaHoc = context.KhoaHoc.Find(id);
                    if (khoaHoc != null)
                    {
                        e.Value = khoaHoc.TenKhoaHoc;
                    }
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "SiSo" || dataGridView.Columns[e.ColumnIndex].Name == "SiSoThucTe")
            {
                var lop = dataGridView.Rows[e.RowIndex].DataBoundItem as LopHoc;
                if (lop != null)
                {
                    e.Value = $"{lop.SiSoThucTe} / {lop.SiSo}";

                    if (lop.SiSoThucTe >= lop.SiSo)
                    {
                        e.CellStyle.ForeColor = Color.Red;
                        e.CellStyle.Font = new Font(dataGridView.Font, FontStyle.Bold);
                    }
                    e.FormattingApplied = true;
                }
            }
        }
        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadData();
            BatTatChucNang(false);
        }
    }
}
