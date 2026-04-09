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
            this.DialogResult = DialogResult.OK;
        }
       
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
            txtMatKhau.Clear();
            txtTenDangNhap.Clear();

            txtTenDangNhap.Focus();
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            txtTenDangNhap.Focus();
        }
    }
}
