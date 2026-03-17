using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyLopHoc_ThemLop : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        public frmQuanLyLopHoc_ThemLop()
        {
            InitializeComponent();
        }
        private void LoadKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc"; 
            cbbKhoaHoc.ValueMember = "ID";
        }
        private void frmQuanLyLopHoc_ThemLop_Load(object sender, EventArgs e)
        {
            LoadKhoaHoc();
            txtTenLopHoc.Clear();
            dtpNgayBatDau.Value = DateTime.Now;
            dtpNgayKetThuc.Value = DateTime.Now;
            rdoDangMo.Checked = true;
            rdoDaDong.Checked = false;
            numSiSo.Value = 0;

            txtTenLopHoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                // check null
                if (string.IsNullOrWhiteSpace(txtTenLopHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên lớp học!");
                    txtTenLopHoc.Focus();
                    return;
                }

                if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu!");
                    return;
                }

                LopHoc lop = new LopHoc();
                lop.TenLopHoc = txtTenLopHoc.Text;
                lop.NgayBatDau = dtpNgayBatDau.Value;
                lop.NgayKetThuc = dtpNgayKetThuc.Value;
                lop.TrangThai = rdoDangMo.Checked;
                lop.KhoaHocID = (int)cbbKhoaHoc.SelectedValue;
                lop.SiSo = (int)numSiSo.Value;

                context.LopHoc.Add(lop);
                context.SaveChanges();

                MessageBox.Show("Thêm lớp học thành công");

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc_ThemLop_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
