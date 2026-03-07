using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using QuanLyTrungTamTinHoc_NgoaiNgu.UserControls.NhanViens;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        public void ShowUserControls(UserControl uc)
        {
            pnlCha.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            pnlCha.Controls.Add(uc);
            uc.BringToFront();
        }
        private void btnQuanLyKhoaHoc_Click(object sender, EventArgs e)
        {
            ShowUserControls(new ucQuanLyKhoaHoc());
        }

        private void btnQuanLyLopHoc_Click(object sender, EventArgs e)
        {
            ShowUserControls(new ucQuanLyLopHoc());
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
