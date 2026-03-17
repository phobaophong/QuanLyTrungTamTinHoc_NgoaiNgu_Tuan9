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

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyLopHoc : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bindingSource = new BindingSource();
        int id;
        bool temp;
        public frmQuanLyLopHoc()
        {
            InitializeComponent();
        }

        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLopHoc.Enabled = giaTri;
            dtpNgayBatDau.Enabled = giaTri;
            dtpNgayKetThuc.Enabled = giaTri;
            rdoDaDong.Enabled = giaTri;
            rdoDangMo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhapExcel.Enabled = !giaTri;
            btnXuatExcel.Enabled = !giaTri;
        }
        private void LoadData()
        {
            var lop = context.LopHoc.ToList();
            bindingSource.DataSource = lop;

            txtTenLopHoc.DataBindings.Clear();
            txtTenLopHoc.DataBindings.Add("Text", bindingSource, "TenLopHoc", false, DataSourceUpdateMode.Never);

            dtpNgayBatDau.DataBindings.Clear();
            dtpNgayBatDau.DataBindings.Add("Value", bindingSource, "NgayBatDau", false, DataSourceUpdateMode.Never);

            dtpNgayKetThuc.DataBindings.Clear();
            dtpNgayKetThuc.DataBindings.Add("Value", bindingSource, "NgayKetThuc", false, DataSourceUpdateMode.Never);

            var current = (LopHoc)bindingSource.Current;

            if (current != null)
            {
                rdoDangMo.Checked = current.TrangThai;
                rdoDaDong.Checked = !current.TrangThai;
            }

            dataGridView.DataSource = bindingSource;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {

            using (frmQuanLyLopHoc_ThemLop them = new frmQuanLyLopHoc_ThemLop())
            {
                them.ShowDialog();
            }
            LoadData();

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = true;
            BatTatChucNang(true);
            txtTenLopHoc.Focus();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            temp = false;
            BatTatChucNang(true);
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp cần xóa!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);

                DialogResult result = MessageBox.Show(
                    "Bạn có chắc muốn xóa lớp này không?",
                    "Xác nhận",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var lop = context.LopHoc.Find(id);

                    if (lop != null)
                    {
                        context.LopHoc.Remove(lop);
                        context.SaveChanges();

                        MessageBox.Show("Xóa thành công");

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy lớp!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (temp) // sửa
            {
                if (dataGridView.CurrentRow == null)
                {
                    MessageBox.Show("Vui lòng chọn lớp cần sửa!");
                    return;
                }

                int id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value);

                var lop = context.LopHoc.Find(id);

                if (lop == null)
                {
                    MessageBox.Show("Không tìm thấy lớp!");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTenLopHoc.Text))
                {
                    MessageBox.Show("Vui lòng nhập tên lớp!");
                    txtTenLopHoc.Focus();
                    return;
                }

                if (dtpNgayKetThuc.Value < dtpNgayBatDau.Value)
                {
                    MessageBox.Show("Ngày kết thúc phải >= ngày bắt đầu!");
                    return;
                }

                lop.TenLopHoc = txtTenLopHoc.Text;
                lop.NgayBatDau = dtpNgayBatDau.Value;
                lop.NgayKetThuc = dtpNgayKetThuc.Value;
                lop.TrangThai = rdoDangMo.Checked;

                context.SaveChanges();

                MessageBox.Show("Cập nhật thành công");

                BatTatChucNang(false);
                LoadData();
            }
            else
            {

            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyLopHoc_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
        private void btnNhapExcel_Click(object sender, EventArgs e)
        {

        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            var current = (LopHoc)dataGridView.CurrentRow.DataBoundItem;

            if (current != null)
            {
                rdoDangMo.Checked = current.TrangThai;
                rdoDaDong.Checked = !current.TrangThai;
            }
        }
        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai")
            {
                if (e.Value != null)
                {
                    bool trangThai = (bool)e.Value;

                    if (trangThai)
                    {
                        e.Value = "Đang mở";
                        e.CellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        e.Value = "Đã kết thúc";
                        e.CellStyle.ForeColor = Color.Red;
                    }
                }
            }

            if (dataGridView.Columns[e.ColumnIndex].Name == "KhoaHocID")
            {
                if (e.Value != null)
                {
                    int id = (int)e.Value;

                    var khoaHoc = context.KhoaHoc.Find(id);
                    if (khoaHoc != null)
                    {
                        e.Value = khoaHoc.TenKhoaHoc;
                    }
                }
            }
        }
        private void frmQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadData();
            BatTatChucNang(false);
        }
    }
}
