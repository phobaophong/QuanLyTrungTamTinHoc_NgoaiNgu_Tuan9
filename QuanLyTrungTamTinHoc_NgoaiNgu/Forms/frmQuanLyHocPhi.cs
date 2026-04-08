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
    public partial class frmQuanLyHocPhi : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int id;
        int idPhieuThu = -1;
        decimal hocPhiKhoaHoc = 0;
        public frmQuanLyHocPhi()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadCbbKhoaHoc();
        }
        private void BatTatCaChucNang(bool giaTri)
        {
            txtSoTien.Enabled = giaTri;
            dtpNgayDong.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnXacNhan.Enabled = giaTri;
            btnSua.Enabled = !giaTri;
        }
        public void LoadCbbKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID"; ;
        }
        public void LoadCbbLopHoc(int id)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == id).ToList();

            cbbLopHoc.DataSource = lop;
            cbbLopHoc.DisplayMember = "TenLopHoc";
            cbbLopHoc.ValueMember = "ID";
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoaHoc.SelectedValue != null && cbbKhoaHoc.SelectedValue is int)
            {
                id = (int)cbbKhoaHoc.SelectedValue;
                LoadCbbLopHoc(id);
            }
        }

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue != null && cbbLopHoc.SelectedValue is int)
            {
                id = (int)cbbLopHoc.SelectedValue;
                LoadDanhSachHocPhi(id);

                var hocphi = context.LopHoc
                   .Include(l => l.KhoaHoc)
                   .Where(l => l.ID == id)
                   .Select(l => l.KhoaHoc.HocPhi)
                   .FirstOrDefault();

                hocPhiKhoaHoc = hocphi;

                if (hocphi != null)
                {
                    lblHocPhi.Text = $"Học phí: {hocphi:N0} VNĐ";
                }
            }
        }

        private void LoadDanhSachHocPhi(int idLop)
        {
            var query = context.HocPhi
                .Include(hp => hp.HocVien)
                .Include(hp => hp.LopHoc)
                .Where(hp => hp.LopHocID == idLop)
                .ToList();

            var danhSachHienThi = query.Select(hp => new DanhSachHocPhi_ChiTiet
            {
                ID = hp.ID,
                HocVienID = hp.HocVienID,
                HoVaTen = hp.HocVien?.HoVaTen,

                LopHocID = hp.LopHocID,
                TenLop = hp.LopHoc?.TenLopHoc,

                SoTienDaDong = hp.SoTienDaDong,
                NgayDong = hp.NgayDong,

                GhiChu = hp.TrangThai ? "Đã đóng đủ" : "Còn nợ"
            }).ToList();


            dataGridView.DataSource = danhSachHienThi;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                BatTatCaChucNang(true);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng học phí để sửa!", "Thông báo");
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var item = dataGridView.CurrentRow.DataBoundItem as DanhSachHocPhi_ChiTiet;
                if (item != null)
                {
                    idPhieuThu = item.ID;

                    txtHoVaTen.Text = item.HoVaTen;
                    txtSoTien.Text = item.SoTienDaDong.ToString("N0");
                    txtTenLop.Text = item.TenLop;
                    if (item.NgayDong.Year < 1753)
                    {
                        dtpNgayDong.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpNgayDong.Value = item.NgayDong;
                    }

                    chkTrangThai.Checked = (item.GhiChu == "Đã đóng đủ");


                    BatTatCaChucNang(false);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                var hocPhiCuaHocVien = context.HocPhi.Find(idPhieuThu);

                if (hocPhiCuaHocVien != null)
                {
                    if (decimal.TryParse(txtSoTien.Text, out decimal soTien))
                    {
                        hocPhiCuaHocVien.SoTienDaDong = soTien;
                    }
                    else
                    {
                        MessageBox.Show("Số tiền không hợp lệ!");
                        return;
                    }
                    hocPhiCuaHocVien.NgayDong = dtpNgayDong.Value.Date;
                    hocPhiCuaHocVien.TrangThai = chkTrangThai.Checked;

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BatTatCaChucNang(false);

                        if (cbbLopHoc.SelectedValue is int idLop)
                        {
                            LoadDanhSachHocPhi(idLop);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu: " + ex.Message);
                    }
                }
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSoTien.Text, out decimal soTien))
            {
                chkTrangThai.Checked = soTien >= hocPhiKhoaHoc;
            }
            else
            {
                chkTrangThai.Checked = false;
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                using (frmInBienLaiHocPhi frmIn = new frmInBienLaiHocPhi(idPhieuThu))
                {
                    frmIn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học viên trên danh sách để in biên lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

