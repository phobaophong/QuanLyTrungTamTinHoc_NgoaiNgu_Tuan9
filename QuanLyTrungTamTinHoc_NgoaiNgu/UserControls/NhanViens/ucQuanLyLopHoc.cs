using Microsoft.EntityFrameworkCore;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using QuanLyTrungTamTinHoc_NgoaiNgu.Forms;
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
    public partial class ucQuanLyLopHoc : UserControl
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        public ucQuanLyLopHoc()
        {
            InitializeComponent();
        }
        private void LayKhoaHocVaoComboBox()
        {
            cboTenKhoaHoc.DataSource = context.KhoaHoc.ToList();
            cboTenKhoaHoc.ValueMember = "ID";
            cboTenKhoaHoc.DisplayMember = "TenKhoaHoc";
        }
        private void BatTatChucNang(bool giaTri)
        {
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnNhap.Enabled = !giaTri;
            btnXuat.Enabled = !giaTri;
            btnHienThiTatCa.Enabled = !giaTri;
        }
        private void ucQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LayKhoaHocVaoComboBox();

            int id = (int)cboTenKhoaHoc.SelectedValue;
            LoadData(id);


        }
        private void LoadData(int khoaHocID)
        {
            var dsLop = context.LopHoc.Where(l => l.KhoaHocID == khoaHocID).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsLop;
            dataGridView.DataSource = bindingSource;
        }

        private void cboTenKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKhoaHoc.SelectedValue != null && cboTenKhoaHoc.SelectedValue is int)
            {
                int id = (int)cboTenKhoaHoc.SelectedValue;
                LoadData(id);

                groupBox1.Text = "Danh sách lớp thuộc khóa";
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "ChiTiet")
            {
                var lopChon = (LopHoc)dataGridView.Rows[e.RowIndex].DataBoundItem;

                if (lopChon != null)
                {
                    var frm = (frmNhanVien)this.FindForm();
                    if (frm != null)
                    {
                        frm.ShowUserControls(new ucQuanLyLopHoc_ThemLop(lopChon.ID));
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = (frmNhanVien)this.FindForm();
            if (frm != null)
            {
                frm.ShowUserControls(new ucQuanLyLopHoc_ThemLop(0)); // id = 0 => thêm lớp
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int lopID = (int)dataGridView.CurrentRow.Cells["ID"].Value;

                var frm = (frmNhanVien)this.FindForm();
                if (frm != null)
                {
                    frm.ShowUserControls(new ucQuanLyLopHoc_ThemLop(lopID));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp học để sửa!", "Thông báo");
            }
        }

        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            var lop = context.LopHoc.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lop;
            dataGridView.DataSource = bindingSource;

            groupBox1.Text = "";
            groupBox2.Text = "Danh sách tất cả các lớp";
            cboTenKhoaHoc.SelectedIndex = -1;
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
        }
    }
}
