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
    public partial class frmThongTinCaNhan : Form
    {
        int idDuLieu; 
        int loai;     

       
        public frmThongTinCaNhan(int idTruyenVao, int loaiTruyenVao)
        {
            InitializeComponent();
            idDuLieu = idTruyenVao;
            loai = loaiTruyenVao;
        }

        private void frmThongTinCaNhan_Load(object sender, EventArgs e)
        {

        }
    }
}
