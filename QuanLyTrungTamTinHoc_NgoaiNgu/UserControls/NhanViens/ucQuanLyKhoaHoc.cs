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
    public partial class ucQuanLyKhoaHoc : UserControl
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        bool xuLy;
        int id;
        public ucQuanLyKhoaHoc()
        {
            InitializeComponent();
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenKhoaHoc.Enabled = giaTri;
            txtHocPhi.Enabled = giaTri;
            txtThoiLuong.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
        }
        private void XoaDuLieuTextBox()
        {
            txtTenKhoaHoc.Clear();
            txtHocPhi.Clear();
            txtThoiLuong.Clear();
        }
        private void ucQuanLyKhoaHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            BatTatChucNang(false);

            List<KhoaHoc> kh = new List<KhoaHoc>();
            kh = context.KhoaHoc.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = kh;

            txtTenKhoaHoc.DataBindings.Clear();
            txtTenKhoaHoc.DataBindings.Add("Text", bindingSource, "TenKhoaHoc", false, DataSourceUpdateMode.Never);

            txtHocPhi.DataBindings.Clear();
            txtHocPhi.DataBindings.Add("Text", bindingSource, "HocPhi", false, DataSourceUpdateMode.Never);

            txtThoiLuong.DataBindings.Clear();
            txtThoiLuong.DataBindings.Add("Text", bindingSource, "ThoiLuong", false, DataSourceUpdateMode.Never);

            dataGridView.DataSource = bindingSource;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xuLy = true;

            BatTatChucNang(true);
            XoaDuLieuTextBox();

            txtTenKhoaHoc.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            xuLy = false;

            BatTatChucNang(true);
            id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
            txtTenKhoaHoc.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenKhoaHoc.Text) ||
                string.IsNullOrWhiteSpace(txtHocPhi.Text) ||
                string.IsNullOrWhiteSpace(txtThoiLuong.Text))
                MessageBox.Show("Vui lòng nhập đủ thông tin khóa học", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (xuLy)
                {
                    KhoaHoc kh = new KhoaHoc();
                    kh.TenKhoaHoc = txtTenKhoaHoc.Text;
                    kh.HocPhi = int.Parse(txtHocPhi.Text);
                    kh.ThoiLuong = int.Parse(txtThoiLuong.Text);

                    context.KhoaHoc.Add(kh);

                    context.SaveChanges();
                }
                else
                {
                    KhoaHoc kh = context.KhoaHoc.Find(id);
                    if (kh != null)
                    {
                        kh.TenKhoaHoc = txtTenKhoaHoc.Text;
                        kh.HocPhi = int.Parse(txtHocPhi.Text);
                        kh.ThoiLuong = int.Parse(txtThoiLuong.Text);
                        context.KhoaHoc.Update(kh);

                        context.SaveChanges();
                    }
                }

                ucQuanLyKhoaHoc_Load(sender, e);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận xóa khóa học " + txtTenKhoaHoc.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value.ToString());
                KhoaHoc kh = context.KhoaHoc.Find(id);
                if (kh != null)
                {
                    context.KhoaHoc.Remove(kh);
                }
                context.SaveChanges();

                ucQuanLyKhoaHoc_Load(sender, e);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            ucQuanLyKhoaHoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
