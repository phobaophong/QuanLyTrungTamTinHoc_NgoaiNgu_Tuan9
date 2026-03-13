using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmDangNhap : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        frmDangNhap dangNhap = null;
        string hoVaTen = "";
        public frmDangNhap()
        {
            InitializeComponent();
        }
        private void DangNhap()
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
                            if (tk.QuyenHan == 1)
                            {
                                QuyenNhanVien();
                                hoVaTen = context.NhanVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => x.HoVaTen).FirstOrDefault();
                            }
                            else if (tk.QuyenHan == 2)
                            {
                                QuyenGiangVien();
                                hoVaTen = context.GiangVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => x.HoVaTen).FirstOrDefault();
                            }
                            else if (tk.QuyenHan == 3)
                            {
                                QuyenHocVien();
                                hoVaTen = context.HocVien.Where(x => x.TaiKhoanID == tk.ID).Select(x => x.HoVaTen).FirstOrDefault();
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
        public void QuyenNhanVien()
        {

        }
        public void QuyenHocVien()
        {

        }
        public void QuyenGiangVien()
        {

        }
        public void ChuaDangNhap()
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
        }
        private void Loadfrm()
        {
            txtTenDangNhap.Clear();
            txtMatKhau.Clear();
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            Loadfrm();
            this.AcceptButton = btnLogin;
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
