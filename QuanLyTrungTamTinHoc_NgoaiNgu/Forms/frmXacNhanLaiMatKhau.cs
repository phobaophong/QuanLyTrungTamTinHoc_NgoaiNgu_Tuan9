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
    public partial class frmXacNhanLaiMatKhau : Form
    {
        public bool XacNhanThanhCong { get; private set; } = false;
        int quyenCanXacNhan;
        public frmXacNhanLaiMatKhau(int quyenHan = 4)
        {
            InitializeComponent();

            quyenCanXacNhan = quyenHan;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string matKhauNhap = txtMatKhau.Text.Trim();

            if (string.IsNullOrEmpty(matKhauNhap))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return;
            }

            using (var db = new QuanLyTrungTamContext())
            {
                var dsTaiKhoan = db.TaiKhoan.Where(tk => tk.QuyenHan == quyenCanXacNhan && tk.TrangThai == true).ToList();
                bool passDung = false;

                foreach (var tk in dsTaiKhoan)
                {
                    if (BC.Verify(matKhauNhap, tk.MatKhau))
                    {
                        passDung = true;
                        break;
                    }
                }

                if (passDung)
                {
                    XacNhanThanhCong = true;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận không chính xác!", "Từ chối truy cập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtMatKhau.Clear();
                    txtMatKhau.Focus();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            XacNhanThanhCong = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLuu_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
