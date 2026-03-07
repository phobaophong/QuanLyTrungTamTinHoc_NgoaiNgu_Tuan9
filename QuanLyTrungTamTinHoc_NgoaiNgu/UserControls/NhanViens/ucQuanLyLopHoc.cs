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
        int id;
        int idKhoaHoc;
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
        private void HienThiDanhSachHocVien()
        {
            if (dataGridView.CurrentRow != null)
            {
                int idLop = (int)dataGridView.CurrentRow.Cells["ID"].Value;

                var frm = (frmNhanVien)this.FindForm();
                if (frm != null)
                {
                    frm.ShowUserControls(new ucQuanLyLopHoc_DanhSachHocVien(idLop));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp học để hiên thị danh sách học viên!", "Thông báo");
            }
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
        private void LoadData(int khoaHocID)
        {
            var dsLop = context.LopHoc.Where(l => l.KhoaHocID == khoaHocID).ToList();
            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = dsLop;
            dataGridView.DataSource = bindingSource;

            dataGridView.ClearSelection();
            btnXoa.Enabled = false;
        }
        private void LoadTatCaCacLop()
        {
            var lop = context.LopHoc.ToList();

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = lop;
            dataGridView.DataSource = bindingSource;

            dataGridView.ClearSelection();
            btnXoa.Enabled = false;


            groupBox1.Text = "";
            groupBox2.Text = "Danh sách tất cả các lớp";
            cboTenKhoaHoc.SelectedIndex = -1;
        }
        private void ucQuanLyLopHoc_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            BatTatChucNang(false);
            LayKhoaHocVaoComboBox();

            if (cboTenKhoaHoc.SelectedValue != null)
            {
                int idKhoaHoc = Convert.ToInt32(cboTenKhoaHoc.SelectedValue);
                LoadData(idKhoaHoc);
            }
            else
            {
                LoadTatCaCacLop();
            }


        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            var frm = (frmNhanVien)this.FindForm();
            if (frm != null)
            {
                frm.ShowUserControls(new ucQuanLyLopHoc_ChiTiet(0)); // id = 0 => thêm lớp
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                int idLop = (int)dataGridView.CurrentRow.Cells["ID"].Value;

                var frm = (frmNhanVien)this.FindForm();
                if (frm != null)
                {
                    frm.ShowUserControls(new ucQuanLyLopHoc_ChiTiet(idLop));
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một lớp học để sửa!", "Thông báo");
            }
        }
        private void btnHienThiTatCa_Click(object sender, EventArgs e)
        {
            LoadTatCaCacLop();
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show("Xác nhận xóa lớp?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow.Cells["ID"].Value);
                    LopHoc lop = context.LopHoc.Find(id);

                    if (lop != null)
                    {
                        context.LopHoc.Remove(lop);
                        context.SaveChanges();
                        MessageBox.Show("Xóa lớp học thành công!", "Thông báo");
                    }

                    // Load lại data sau khi xóa
                    if (cboTenKhoaHoc.SelectedValue != null)
                    {
                        LoadData(Convert.ToInt32(cboTenKhoaHoc.SelectedValue));
                    }
                    else
                    {
                        LoadTatCaCacLop();
                    }
                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    // không thể xóa do có học viên
                    MessageBox.Show("Không thể xóa lớp học này vì đang có học viên hoặc dữ liệu liên quan!", "Lỗi ràng buộc", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
                        frm.ShowUserControls(new ucQuanLyLopHoc_ChiTiet(lopChon.ID));
                    }
                }
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            btnXoa.Enabled = dataGridView.CurrentRow != null;
        }

        private void cboTenKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTenKhoaHoc.SelectedValue != null && cboTenKhoaHoc.SelectedValue is int)
            {
                idKhoaHoc = (int)cboTenKhoaHoc.SelectedValue;
                LoadData(idKhoaHoc);

                groupBox1.Text = "Danh sách lớp thuộc khóa";
            }
        }

        private void btnDanhSachHocVien_Click(object sender, EventArgs e)
        {
            HienThiDanhSachHocVien();
        }
    }
}
