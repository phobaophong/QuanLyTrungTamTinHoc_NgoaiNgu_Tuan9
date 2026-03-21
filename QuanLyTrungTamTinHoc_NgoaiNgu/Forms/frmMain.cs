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
    public partial class frmMain : Form
    {
        frmQuanLyKhoaHoc quanLyKhoaHoc = null;
        frmQuanLyLopHoc quanLyLopHoc = null;
        frmQuanLyHocVien quanLyHocVien = null;
        public frmMain()
        {
            InitializeComponent();
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
    }
}
