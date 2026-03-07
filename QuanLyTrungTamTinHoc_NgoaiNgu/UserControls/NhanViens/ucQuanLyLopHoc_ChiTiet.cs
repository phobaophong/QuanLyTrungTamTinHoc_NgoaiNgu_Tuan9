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

namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls.NhanViens
{
    public partial class ucQuanLyLopHoc_ChiTiet : UserControl
    {
        int id;
        bool trangthai = true;
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        public ucQuanLyLopHoc_ChiTiet(int idQuanLy = 0)
        {
            InitializeComponent();
            id = idQuanLy;
        }
        private void HienThiDanhSachHocVien()
        {
            pnlDanhSachHocVien.Controls.Clear();
            ucQuanLyLopHoc_DanhSachHocVien ucDS = new ucQuanLyLopHoc_DanhSachHocVien(this.id);
            ucDS.Dock = DockStyle.Fill;
            pnlDanhSachHocVien.Controls.Add(ucDS);
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLopHoc.Enabled = giaTri;
            cboTenKhoaHoc.Enabled = giaTri;
            ckbDaKetThuc.Enabled = giaTri;
            ckbDangMo.Enabled = giaTri;
            dtpNgayBatDau.Enabled = giaTri;
            dtpNgayKetThuc.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnDanhSachHocVien.Enabled = !giaTri;
        }
        private void LayKhoaHocVaoComboBox()
        {
            cboTenKhoaHoc.DataSource = context.KhoaHoc.ToList();
            cboTenKhoaHoc.ValueMember = "ID";
            cboTenKhoaHoc.DisplayMember = "TenKhoaHoc";
        }
        private void XoaTatCaData()
        {
            txtTenLopHoc.Clear();

            ckbDangMo.Checked = true;
            ckbDaKetThuc.Checked = false;

            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;

            cboTenKhoaHoc.SelectedIndex = -1;

        }
        private void ucQuanLyLopHoc_ThemLop_Load(object sender, EventArgs e)
        {
            LayKhoaHocVaoComboBox();
            if (id == 0)
            {
                BatTatChucNang(true);
                XoaTatCaData();
                trangthai = true;
            }
            else
            {
                LoadData();
                BatTatChucNang(true);
                btnDanhSachHocVien.Enabled = true;
                trangthai = false;
            }
        }
        private void LoadData()
        {
            var lop = context.LopHoc.Find(id);

            if (lop != null)
            {
                txtTenLopHoc.Text = lop.TenLopHoc;
                ckbDangMo.Checked = lop.TrangThai;
                ckbDaKetThuc.Checked = !lop.TrangThai;
                dtpNgayBatDau.Value = lop.NgayBatDau;
                dtpNgayKetThuc.Value = lop.NgayKetThuc;
                cboTenKhoaHoc.SelectedValue = lop.KhoaHocID;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            trangthai = true;
            BatTatChucNang(true);
            XoaTatCaData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            trangthai = false;
            BatTatChucNang(true);
            txtTenLopHoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenLopHoc.Text))
            {
                MessageBox.Show("Vui lòng nhập tên lớp.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTenLopHoc.Focus();
            }
            else if (cboTenKhoaHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn khóa học.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboTenKhoaHoc.Focus();
            }
            else if (dtpNgayKetThuc.Value.Date < dtpNgayBatDau.Value.Date)
            {
                MessageBox.Show("Ngày kết thúc phải lớn hơn hoặc bằng ngày bắt đầu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpNgayKetThuc.Focus();
            }
            else
            {
                if (trangthai)
                {
                    LopHoc lop = new LopHoc();
                    lop.TenLopHoc = txtTenLopHoc.Text;
                    lop.TrangThai = true;
                    lop.NgayBatDau = dtpNgayBatDau.Value;
                    lop.NgayKetThuc = dtpNgayKetThuc.Value;
                    lop.KhoaHocID = (int)cboTenKhoaHoc.SelectedValue;

                    context.LopHoc.Add(lop);
                    context.SaveChanges();
                    MessageBox.Show("Thêm lớp học thành công!");
                }
                else
                {
                    LopHoc lop = context.LopHoc.Find(id);

                    if (lop != null)
                    {
                        lop.TenLopHoc = txtTenLopHoc.Text;
                        lop.NgayBatDau = dtpNgayBatDau.Value;
                        lop.NgayKetThuc = dtpNgayKetThuc.Value;
                        lop.TrangThai = ckbDangMo.Checked;
                        lop.KhoaHocID = (int)cboTenKhoaHoc.SelectedValue;

                        context.SaveChanges();
                        MessageBox.Show("Cập nhật thông tin thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp học có ID = " + id);
                    }
                }
                btnHuyBo_Click(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            var frm = (Forms.frmNhanVien)this.FindForm();
            if (frm != null)
            {
                frm.ShowUserControls(new ucQuanLyLopHoc());
            }
        }

        private void ckbDangMo_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDangMo.Checked)
            {
                ckbDaKetThuc.Checked = false;
            }
        }

        private void ckbDaKetThuc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbDaKetThuc.Checked)
            {
                ckbDangMo.Checked = false;
            }
        }

        private void dtpNgayKetThuc_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnDanhSachHocVien_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHocVien();
        }
    }
}
