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
    public partial class frmQuanLyDiemSo : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bsDiem = new BindingSource();
        int idLopHocDangChon = 0;
        bool isUpdating = false;
        public frmQuanLyDiemSo()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmQuanLyDiemSo_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            btnLuu.Enabled = false;
            txtHoVaTen.Enabled = false;
            txtMaSo.Enabled = false;
            txtTenLop.Enabled = false;
            btnTaoLopOnThi.Visible = false;

            lblHoiYKien.Visible = false;

            LoadCbbKhoaHoc();
        }
        public void LoadCbbKhoaHoc()
        {
            context = new QuanLyTrungTamContext();
            var kh = context.KhoaHoc.ToList();

            if (kh.Count > 0)
            {
                cboKhoaHoc.DataSource = kh;
                cboKhoaHoc.DisplayMember = "TenKhoaHoc";
                cboKhoaHoc.ValueMember = "ID";
            }
            else
            {
                cboKhoaHoc.DataSource = null;
                cboKhoaHoc.Text = "Chưa có khóa học";
            }
        }

        public void LoadCbbLopHoc(int idKhoa)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == idKhoa).ToList();

            if (lop.Count > 0)
            {
                cboLopHoc.DataSource = lop;
                cboLopHoc.DisplayMember = "TenLopHoc";
                cboLopHoc.ValueMember = "ID";
            }
            else
            {
                cboLopHoc.DataSource = null;
                cboLopHoc.Text = "Chưa có lớp học";

                bsDiem.DataSource = null;
                dataGridView.DataSource = null;
            }
        }
        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoaHoc.SelectedValue != null && cboKhoaHoc.SelectedValue is int id)
            {
                LoadCbbLopHoc(id);
            }
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLopHoc.SelectedValue != null && cboLopHoc.SelectedValue is int id)
            {
                idLopHocDangChon = id;
                LoadData(id, null);
            }
        }
        public void LoadData(int idLop, float? locDiemThat)
        {
            var dsHocVien = context.HocVien
                .Where(hv => hv.HocPhi.Any(hp => hp.LopHocID == idLop))
                .ToList();

            var dsKetQua = context.KetQua
                .Where(k => k.LopHocID == idLop)
                .ToList();

            var lopHoc = context.LopHoc.Find(idLop);
            string tenLop = lopHoc != null ? lopHoc.TenLopHoc : "";

            var danhSachHienThi = dsHocVien.Select(hv =>
            {
                var kq = dsKetQua.FirstOrDefault(k => k.HocVienID == hv.ID);
                return new DanhSachDiemSo_ChiTiet
                {
                    ID = kq != null ? kq.ID : 0,
                    HocVienID = hv.ID,
                    MaSo = hv.MaSo,
                    HoVaTen = hv.HoVaTen,
                    LopHocID = idLop,
                    TenLop = tenLop,
                    DiemThiThu = kq?.DiemThiThu,
                    DiemThiThat = kq?.DiemThiThat
                };
            }).AsEnumerable();

            if (locDiemThat != null)
            {
                if (locDiemThat >= 5.0f)
                    danhSachHienThi = danhSachHienThi.Where(x => x.DiemThiThat >= 5.0f);
                else
                    danhSachHienThi = danhSachHienThi.Where(x => x.DiemThiThat.HasValue && x.DiemThiThat < 5.0f);
            }

            bsDiem.DataSource = new BindingList<DanhSachDiemSo_ChiTiet>(danhSachHienThi.ToList());
            dataGridView.DataSource = bsDiem;

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.Name == "DiemThiThu" || col.Name == "DiemThiThat")
                    col.ReadOnly = false;
                else
                    col.ReadOnly = true;
            }

            btnTaoLopOnThi.Visible = (locDiemThat != null && locDiemThat < 5.0f);
        }

        private void numDiemThiThu_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && btnLuu.Enabled && !isUpdating)
                dataGridView.CurrentRow.Cells["DiemThiThu"].Value = (float)numDiemThiThu.Value;
        }


        private void numDiemThiThat_ValueChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null && btnLuu.Enabled && !isUpdating)
            {
                dataGridView.CurrentRow.Cells["DiemThiThat"].Value = (float)numDiemThiThat.Value;
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var row = dataGridView.CurrentRow.DataBoundItem as DanhSachDiemSo_ChiTiet;
            if (row != null)
            {
                isUpdating = true;
                txtMaSo.Text = row.MaSo;
                txtHoVaTen.Text = row.HoVaTen;
                txtTenLop.Text = row.TenLop;

                numDiemThiThu.Value = row.DiemThiThu.HasValue ? (decimal)row.DiemThiThu.Value : 0m;
                numDiemThiThat.Value = row.DiemThiThat.HasValue ? (decimal)row.DiemThiThat.Value : 0m;

                isUpdating = false;
            }
        }

        private void btnDsTren5Diem_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0) LoadData(idLopHocDangChon, 5.0f);
        }

        private void btnDsDuoi5Diem_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0) LoadData(idLopHocDangChon, 4.9f);

            lblHoiYKien.Visible = true;
        }

        private void btnTaoLopOnThi_Click(object sender, EventArgs e)
        {
            using (frmQuanLyLopHoc_ThemLop frmThemLop = new frmQuanLyLopHoc_ThemLop(0))
            {
                frmThemLop.Text = "Tạo Lớp Ôn Tập Thi Lại";
                frmThemLop.ShowDialog();
            }
            lblHoiYKien.Visible = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            btnLuu.Enabled = true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            dataGridView.EndEdit();
            bsDiem.EndEdit();

            var dsHienThi = bsDiem.DataSource as BindingList<DanhSachDiemSo_ChiTiet>;
            if (dsHienThi == null || idLopHocDangChon == 0) return;

            foreach (var item in dsHienThi)
            {
                int idHV = item.HocVienID;
                int idLop = item.LopHocID;
                float? diemThiThu = item.DiemThiThu;
                float? diemThiThat = item.DiemThiThat;

                var kq = context.KetQua.FirstOrDefault(k => k.LopHocID == idLop && k.HocVienID == idHV);

                if (kq == null)
                {
                    if (diemThiThu.HasValue || diemThiThat.HasValue)
                    {
                        context.KetQua.Add(new KetQua
                        {
                            LopHocID = idLop,
                            HocVienID = idHV,
                            DiemThiThu = diemThiThu,
                            DiemThiThat = diemThiThat
                        });
                    }
                }
                else
                {
                    kq.DiemThiThu = diemThiThu;
                    kq.DiemThiThat = diemThiThat;

                    if (!kq.DiemThiThu.HasValue && !kq.DiemThiThat.HasValue)
                    {
                        context.KetQua.Remove(kq);
                    }
                }
            }

            try
            {
                context.SaveChanges();
                MessageBox.Show("Lưu điểm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLuu.Enabled = false;

                LoadData(idLopHocDangChon, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            if (idLopHocDangChon != 0)
                LoadData(idLopHocDangChon, null);

            btnLuu.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
