using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmMain : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        frmQuanLyKhoaHoc quanLyKhoaHoc = null;
        frmQuanLyLopHoc quanLyLopHoc = null;
        frmQuanLyHocVien quanLyHocVien = null;
        frmQuanLyNhanSu quanLyNhanSu = null;
        frmThoiKhoaBieu thoiKhoaBieu = null;
        frmDangNhap dangNhap = null;
        frmQuanLyHocPhi hocPhi = null;
        frmQuanLyDiemSo diemSo = null;
        frmTraCuuDiemThiThu traCuuDiemThiThu = null;
        frmThongTinCaNhan thongTinCaNhan = null;
        string hoVaTen = "";
        int idDangNhap;
        int idQuyenHan;
        public frmMain()
        {
            InitializeComponent();
        }

        public void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)

                dangNhap = new frmDangNhap();

            if (dangNhap.ShowDialog() == DialogResult.OK)
            {
                string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                string matKhau = dangNhap.txtMatKhau.Text;

                if (tenDangNhap.Trim() == "")
                {
                    MessageBox.Show("Tên đăng nhập không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtTenDangNhap.Focus();
                    goto LamLai;
                }
                else if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Mật khẩu không được bỏ trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dangNhap.txtMatKhau.Focus();
                    goto LamLai;
                }
                else
                {
                    var tk = context.TaiKhoan.Where(r => r.TenDN == tenDangNhap).SingleOrDefault();

                    if (tk == null)
                    {
                        MessageBox.Show("Tên đăng nhập không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        if (BC.Verify(matKhau, tk.MatKhau))
                        {
                            idQuyenHan = tk.QuyenHan;
                            if (tk.QuyenHan == 1)
                            {
                                var nv = context.NhanVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => new { x.ID, x.HoVaTen }).FirstOrDefault();

                                if (nv != null)
                                {
                                    idDangNhap = nv.ID;
                                    hoVaTen = nv.HoVaTen;
                                }

                                QuyenNhanVien();

                            }
                            else if (tk.QuyenHan == 2)
                            {
                                var gv = context.GiangVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => new { x.ID, x.HoVaTen }).FirstOrDefault();

                                if (gv != null)
                                {
                                    idDangNhap = gv.ID;
                                    hoVaTen = gv.HoVaTen;
                                }

                                QuyenGiangVien();
                            }
                            else if (tk.QuyenHan == 3)
                            {
                                var hv = context.HocVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => new { x.ID, x.HoVaTen }).FirstOrDefault();

                                if (hv != null)
                                {
                                    idDangNhap = hv.ID;
                                    hoVaTen = hv.HoVaTen;
                                }

                                QuyenHocVien();

                            }
                            else
                                ChuaDangNhap();
                        }
                        else
                        {
                            MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            dangNhap.txtMatKhau.Focus();
                            goto LamLai;
                        }
                    }
                }
            }
        }
        private void mnuTraCuuTTCN_Click(object sender, EventArgs e)
        {
            if (thongTinCaNhan == null || thongTinCaNhan.IsDisposed)
            {
                thongTinCaNhan = new frmThongTinCaNhan(idDangNhap, idQuyenHan);
                thongTinCaNhan.MdiParent = this;
                thongTinCaNhan.Dock = DockStyle.Fill;
                thongTinCaNhan.Show();
            }
            else
                hocPhi.Activate();
        }
        private void mnuTraCuuDiemThiThu_Click(object sender, EventArgs e)
        {
            if (traCuuDiemThiThu == null || traCuuDiemThiThu.IsDisposed)
            {
                traCuuDiemThiThu = new frmTraCuuDiemThiThu();
                traCuuDiemThiThu.MdiParent = this;
                traCuuDiemThiThu.Dock = DockStyle.Fill;
                traCuuDiemThiThu.Show();
            }
            else
                hocPhi.Activate();
        }
        private void mnuQuanLyHocPhi_Click(object sender, EventArgs e)
        {
            if (hocPhi == null || hocPhi.IsDisposed)
            {
                hocPhi = new frmQuanLyHocPhi();
                hocPhi.MdiParent = this;
                hocPhi.Dock = DockStyle.Fill;
                hocPhi.Show();
            }
            else
                hocPhi.Activate();
        }
        private void mnuQuanLyKhoaHoc_Click(object sender, EventArgs e)
        {
            if (quanLyKhoaHoc == null || quanLyKhoaHoc.IsDisposed)
            {
                quanLyKhoaHoc = new frmQuanLyKhoaHoc();
                quanLyKhoaHoc.MdiParent = this;
                quanLyKhoaHoc.Dock = DockStyle.Fill;
                quanLyKhoaHoc.Show();
            }
            else
                quanLyKhoaHoc.Activate();
        }

        private void mnuQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            if (quanLyLopHoc == null || quanLyLopHoc.IsDisposed)
            {
                quanLyLopHoc = new frmQuanLyLopHoc();
                quanLyLopHoc.MdiParent = this;
                quanLyLopHoc.Dock = DockStyle.Fill;
                quanLyLopHoc.Show();
            }
            else
                quanLyLopHoc.Activate();
        }

        private void mnuQuanLySinhVien_Click(object sender, EventArgs e)
        {
            if (quanLyHocVien == null || quanLyHocVien.IsDisposed)
            {
                quanLyHocVien = new frmQuanLyHocVien();
                quanLyHocVien.MdiParent = this;
                quanLyHocVien.Dock = DockStyle.Fill;
                quanLyHocVien.Show();
            }
            else
                quanLyHocVien.Activate();
        }


        private void mnuQuanLyDiemSo_Click(object sender, EventArgs e)
        {
            if (diemSo == null || diemSo.IsDisposed)
            {
                diemSo = new frmQuanLyDiemSo();
                diemSo.MdiParent = this;
                diemSo.Dock = DockStyle.Fill;
                diemSo.Show();
            }
            else
                diemSo.Activate();
        }

        private void quảnLýNhânSựToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (quanLyNhanSu == null || quanLyNhanSu.IsDisposed)
            {
                quanLyNhanSu = new frmQuanLyNhanSu();
                quanLyNhanSu.MdiParent = this;
                quanLyNhanSu.Dock = DockStyle.Fill;
                quanLyNhanSu.Show();
            }
            else
                quanLyNhanSu.Activate();
        }

        private void lịchHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thoiKhoaBieu == null || thoiKhoaBieu.IsDisposed)
            {
                thoiKhoaBieu = new frmThoiKhoaBieu();
                thoiKhoaBieu.MdiParent = this;
                thoiKhoaBieu.Dock = DockStyle.Fill;
                thoiKhoaBieu.Show();
            }
            else
                thoiKhoaBieu.Activate();
        }


        private void lblLienKet_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "explorer.exe";
            info.Arguments = "https://fit.agu.edu.vn";
            Process.Start(info);
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach (Form child in MdiChildren)
            {
                child.Close();
            }
            ChuaDangNhap();
        }


        public void ChuaDangNhap()
        {
            mnuDangNhap.Enabled = true;
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;

            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";
        }


        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;


            lblTrangThai.Text = "Nhân viên: " + hoVaTen;
        }
        public void QuyenGiangVien()
        {
            mnuDangNhap.Enabled = false;

            mnuQuanLyHocPhi.Visible = false;
            mnuQuanLyLopHoc.Visible = false;
            mnuQuanLyKhoaHoc.Visible = false;
            mnuQuanLyHocVien.Visible = false;
            mnuQuanLyNhanSu.Visible = false;

            lblTrangThai.Text = "Giảng viên: " + hoVaTen;
        }

        public void QuyenHocVien()
        {
            mnuDangNhap.Enabled = false; 

            mnuQuanLy.Visible = false;

            lblTrangThai.Text = "Học viên: " + hoVaTen;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();

        }
    }
}
