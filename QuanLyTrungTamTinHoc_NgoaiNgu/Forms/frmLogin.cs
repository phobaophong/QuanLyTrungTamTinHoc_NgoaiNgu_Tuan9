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
    public partial class frmLogin : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo");
                return;
            }

            var tk = context.TaiKhoan.FirstOrDefault(x => x.TenDN == txtTenDangNhap.Text.Trim());

            if (tk != null)
            {
                bool match = BCrypt.Net.BCrypt.Verify(txtMatKhau.Text.Trim(), tk.MatKhau);
                if (match)
                {
                    if (!tk.TrangThai)
                    {
                        MessageBox.Show("Tài khoản chưa kích hoạt hoặc bị khóa!", "Thông báo");
                        return;
                    }

                    // Lưu thông tin tài khoản đang đăng nhập
                    TaiKhoanHienTai.ID = tk.ID;
                    TaiKhoanHienTai.TenDN = tk.TenDN;
                    TaiKhoanHienTai.Quyen = tk.QuyenHan;

                    int quyen = tk.QuyenHan;
                    if (quyen == 1)
                    {
                        frmNhanVien f = new frmNhanVien();
                        this.Hide();
                        f.ShowDialog();
                        this.Show();
                    }
                    else if (quyen == 2)
                    {
                        // Mở form dành cho giảng viên
                    }
                    else if (quyen == 3)
                    {
                        // Mở form dành cho học viên
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Lỗi");
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            
        }
    }
}
