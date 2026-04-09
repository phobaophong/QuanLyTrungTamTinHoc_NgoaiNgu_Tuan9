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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmDoiMatKhau : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int idTaiKhoanDangNhap;
        public frmDoiMatKhau(int idTaiKhoan)
        {
            InitializeComponent();

            idTaiKhoanDangNhap = idTaiKhoan;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMatKhauCu.Clear();
            txtMatKhauMoi.Clear();
            txtXacNhan.Clear();
            txtMatKhauCu.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            // check null
            if (string.IsNullOrWhiteSpace(txtMatKhauCu.Text) ||
                string.IsNullOrWhiteSpace(txtMatKhauMoi.Text) ||
                string.IsNullOrWhiteSpace(txtXacNhan.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // check mk mới trùng mk cũ
            if (txtMatKhauMoi.Text == txtMatKhauCu.Text)
            {
                MessageBox.Show("Mật khẩu mới không được trùng với mật khẩu cũ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhauMoi.Focus();
                return;
            }
            // check mk mới và mk xác nhận không trùng nhau
            if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtXacNhan.Focus();
                return;
            }

            try
            {
                var tk = context.TaiKhoan.Find(idTaiKhoanDangNhap);
                if (tk == null)
                {
                    MessageBox.Show("Không tìm thấy tài khoản trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!BC.Verify(txtMatKhauCu.Text, tk.MatKhau))
                {
                    MessageBox.Show("Mật khẩu cũ không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhauCu.Focus();
                    return;
                }

                tk.MatKhau = BC.HashPassword(txtMatKhauMoi.Text);
                context.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmDoiMatKhau_Load(sender, e);
        }

        private void chkHienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThiMatKhau.Checked)
            {
                txtMatKhauCu.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
                txtXacNhan.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhauCu.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
                txtXacNhan.UseSystemPasswordChar = true;
            }
        }
    }
}
