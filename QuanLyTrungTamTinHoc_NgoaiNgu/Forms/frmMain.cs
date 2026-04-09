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
        frmThongKeDoanhThu thongKeDoanhThu = null;
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
                    context = new QuanLyTrungTamContext();

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
                            else if (tk.QuyenHan == 4) // quyền admin
                            {
                                var nv = context.NhanVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => new { x.ID, x.HoVaTen }).FirstOrDefault();

                                if (nv != null)
                                {
                                    idDangNhap = nv.ID;
                                    hoVaTen = nv.HoVaTen;
                                }

                                QuyenAdmin();

                            }
                            else if (tk.QuyenHan == 5) // quyền thu ngân
                            {
                                var nv = context.NhanVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => new { x.ID, x.HoVaTen }).FirstOrDefault();

                                if (nv != null)
                                {
                                    idDangNhap = nv.ID;
                                    hoVaTen = nv.HoVaTen;
                                }

                                QuyenThuNgan();

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
                quanLyKhoaHoc = new frmQuanLyKhoaHoc(idQuyenHan);
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
                quanLyLopHoc = new frmQuanLyLopHoc(idQuyenHan);
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
                diemSo = new frmQuanLyDiemSo(idQuyenHan);
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
                quanLyNhanSu = new frmQuanLyNhanSu(idQuyenHan);
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
                thoiKhoaBieu = new frmThoiKhoaBieu(idQuyenHan, idDangNhap);
                thoiKhoaBieu.MdiParent = this;
                thoiKhoaBieu.Dock = DockStyle.Fill;
                thoiKhoaBieu.Show();
            }
            else
                thoiKhoaBieu.Activate();
        }
        private void mnuQuanLyDoanhThu_Click(object sender, EventArgs e)
        {
            if (thongKeDoanhThu == null || thongKeDoanhThu.IsDisposed)
            {
                thongKeDoanhThu = new frmThongKeDoanhThu();
                thongKeDoanhThu.MdiParent = this;
                thongKeDoanhThu.Dock = DockStyle.Fill;
                thongKeDoanhThu.Show();
            }
            else
                thongKeDoanhThu.Activate();
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

            mnuQuanLy.Visible = false;


            // Hiển thị thông tin trên thanh trạng thái 
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenAdmin()
        {
            mnuDangNhap.Enabled = false;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;

            mnuQuanLy.Visible = true;
            lblTrangThai.Text = "Quản trị viên: " + hoVaTen;
        }

        public void QuyenNhanVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;

            mnuQuanLy.Visible = true;
            mnuQuanLyDoanhThu.Visible = false;
            lblTrangThai.Text = "Nhân viên: " + hoVaTen;
        }
        public void QuyenThuNgan()
        {
            mnuDangNhap.Enabled = false;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;

            mnuQuanLy.Visible = true;
            mnuQuanLyHocPhi.Visible = true;
            mnuQuanLyDoanhThu.Visible = true;

            mnuQuanLyLopHoc.Visible = false;
            mnuQuanLyKhoaHoc.Visible = false;
            mnuQuanLyHocVien.Visible = false;
            mnuQuanLyNhanSu.Visible = false;
            mnuQuanLyDiemSo.Visible = false;

            lblTrangThai.Text = "Nhân viên thu ngân: " + hoVaTen;
        }
        public void QuyenGiangVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;

            mnuQuanLy.Visible = true;
            mnuQuanLyHocPhi.Visible = false;
            mnuQuanLyLopHoc.Visible = false;
            mnuQuanLyKhoaHoc.Visible = false;
            mnuQuanLyHocVien.Visible = false;
            mnuQuanLyNhanSu.Visible = false;
            mnuQuanLyDoanhThu.Visible = false;

            lblTrangThai.Text = "Giảng viên: " + hoVaTen;
        }

        public void QuyenHocVien()
        {
            mnuDangNhap.Enabled = false;
            mnuDoiMatKhau.Enabled = true;
            mnuDangXuat.Enabled = true;

            mnuQuanLy.Visible = false;

            lblTrangThai.Text = "Học viên: " + hoVaTen;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaDangNhap();
            DangNhap();

        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDoiMatKhau_Click(object sender, EventArgs e)
        {
            int? idTK = null;
            if (idQuyenHan == 1 || idQuyenHan == 4 || idQuyenHan == 5)
                idTK = context.NhanVien.Find(idDangNhap)?.TaiKhoanID;
            else if (idQuyenHan == 2)
                idTK = context.GiangVien.Find(idDangNhap)?.TaiKhoanID;
            else if (idQuyenHan == 3)
                idTK = context.HocVien.Find(idDangNhap)?.TaiKhoanID;

            if (idTK == null)
            {
                MessageBox.Show("Không tìm thấy thông tin tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmDoiMatKhau frm = new frmDoiMatKhau(idTK.Value);
            frm.ShowDialog();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát phần mềm?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }
    }
}
