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

namespace QuanLyTrungTamTinHoc_NgoaiNgu.UserControls.NhanViens
{
    public partial class ucQuanLyLopHoc_DanhSachHocVien : UserControl
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int id;
        public ucQuanLyLopHoc_DanhSachHocVien(int idLop)
        {
            InitializeComponent();
            this.id = idLop;
        }

        private void ucQuanLyLopHoc_DanhSachHocVien_Load(object sender, EventArgs e)
        {
            if(id != 0)
            {
                LopHoc lop = context.LopHoc.Find(id);
                groupBox1.Text += lop.TenLopHoc;
            }
            
        }
    }
}
