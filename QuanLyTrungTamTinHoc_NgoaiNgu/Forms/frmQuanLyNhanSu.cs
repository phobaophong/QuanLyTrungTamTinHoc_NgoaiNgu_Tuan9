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
using BC = BCrypt.Net.BCrypt;

namespace QuanLyTrungTamTinHoc_NgoaiNgu.Forms
{
    public partial class frmQuanLyNhanSu : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bindingSource = new BindingSource();
        string folderAnh = @"D:\Project\ĐỒ ÁN - Lập trình quản lý\HinhNen\";
        string fileNameHinhAnh = "";
        bool temp = true;
        int loaiNhanSu = 2; //1 nhân viên, 2 giảng viên
        public frmQuanLyNhanSu()
        {
            InitializeComponent();
        }
        public void BatTatCaChucNang(bool giaTri)
        {
            txtHoVaTen.Enabled = giaTri;
            txtMaSo.Enabled = giaTri;
            txtBoPhan.Enabled = giaTri;
            dtpNgaySinh.Enabled = giaTri;
            rdoNam.Enabled = giaTri;
            rdoNu.Enabled = giaTri;
            btnXacNhan.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
            txtSdt.Enabled = giaTri;
            txtEmail.Enabled = giaTri;

            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            LoadGiangVien();
        }
        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
        }
        private void LoadGiangVien()
        {
            loaiNhanSu = 2;
            var gv = context.GiangVien.ToList();

            bindingSource.DataSource = gv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtMaSo.DataBindings.Clear();
            txtMaSo.DataBindings.Add("Text", bindingSource, "MaSo", false, DataSourceUpdateMode.Never);

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", bindingSource, "Sdt", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtBoPhan.DataBindings.Clear();
            txtBoPhan.DataBindings.Add("Text", bindingSource, "BoPhan", false, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            var bindingNgaySinh = new Binding("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Add(bindingNgaySinh);

            rdoNam.DataBindings.Clear();
            rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            rdoNu.DataBindings.Clear();
            Binding bdNu = new Binding("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            bdNu.Format += (s, args) => args.Value = !(bool)args.Value;
            rdoNu.DataBindings.Add(bdNu);

            dataGridView.DataSource = bindingSource;
            BatTatCaChucNang(false);
        }

        private void LoadNhanVien()
        {
            loaiNhanSu = 1;
            var nv = context.NhanVien.ToList();

            bindingSource.DataSource = nv;

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);

            txtMaSo.DataBindings.Clear();
            txtMaSo.DataBindings.Add("Text", bindingSource, "MaSo", false, DataSourceUpdateMode.Never);

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", bindingSource, "Sdt", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);

            txtBoPhan.DataBindings.Clear();
            txtBoPhan.DataBindings.Add("Text", bindingSource, "BoPhan", false, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            var bindingNgaySinh = new Binding("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Add(bindingNgaySinh);

            rdoNam.DataBindings.Clear();
            rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            rdoNu.DataBindings.Clear();
            Binding bdNu = new Binding("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
            bdNu.Format += (s, args) => args.Value = !(bool)args.Value;
            rdoNu.DataBindings.Add(bdNu);

            dataGridView.DataSource = bindingSource;
            BatTatCaChucNang(false);
        }


        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadGiangVien();
            bindingSource.CurrentChanged += bindingSource_CurrentChanged;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            temp = true;
            BatTatCaChucNang(true);

            txtMaSo.Clear();
            txtHoVaTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            txtDiaChi.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtBoPhan.Clear();

            fileNameHinhAnh = "";
            if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
            picHinhAnh.Image = Properties.Resources.nam_avatar;

            txtMaSo.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show($"Xác nhận xóa {txtHoVaTen.Text}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (loaiNhanSu == 2) // Giảng viên
                {
                    var gv = bindingSource.Current as GiangVien;
                    if (gv != null) context.GiangVien.Remove(gv);
                }
                else // Nhân viên
                {
                    var nv = bindingSource.Current as NhanVien;
                    if (nv != null) context.NhanVien.Remove(nv);
                }

                context.SaveChanges();
                MessageBox.Show("Xóa thành công!", "Thông báo");

                if (loaiNhanSu == 2) LoadGiangVien(); else LoadNhanVien();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            temp = false;
            BatTatCaChucNang(true);
            txtMaSo.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (temp) // THÊM MỚI
                {
                    // 1. Tạo Tài khoản chung
                    TaiKhoan tk = new TaiKhoan();
                    tk.TenDN = txtMaSo.Text.Trim();
                    tk.MatKhau = BC.HashPassword("1");
                    tk.TrangThai = true;
                    tk.QuyenHan = loaiNhanSu; // 1: Nhân viên, 2: Giảng viên

                    context.TaiKhoan.Add(tk);
                    context.SaveChanges();

                    if (loaiNhanSu == 2) // Giảng viên
                    {
                        GiangVien gv = new GiangVien();
                        gv.MaSo = txtMaSo.Text.Trim();
                        gv.HoVaTen = txtHoVaTen.Text.Trim();
                        gv.NgaySinh = dtpNgaySinh.Value;
                        gv.GioiTinh = rdoNam.Checked;
                        gv.DiaChi = txtDiaChi.Text.Trim();
                        gv.Sdt = txtSdt.Text.Trim();
                        gv.Email = txtEmail.Text.Trim();
                        gv.BoPhan = txtBoPhan.Text.Trim();
                        gv.HinhAnh = fileNameHinhAnh;
                        gv.TaiKhoanID = tk.ID;

                        context.GiangVien.Add(gv);
                    }
                    else // Nhân viên
                    {
                        NhanVien nv = new NhanVien();
                        nv.MaSo = txtMaSo.Text.Trim();
                        nv.HoVaTen = txtHoVaTen.Text.Trim();
                        nv.NgaySinh = dtpNgaySinh.Value;
                        nv.GioiTinh = rdoNam.Checked;
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.Sdt = txtSdt.Text.Trim();
                        nv.Email = txtEmail.Text.Trim();
                        nv.BoPhan = txtBoPhan.Text.Trim();
                        nv.HinhAnh = fileNameHinhAnh;
                        nv.TaiKhoanID = tk.ID;

                        context.NhanVien.Add(nv);
                    }

                    context.SaveChanges();
                    MessageBox.Show("Thêm nhân sự và cấp tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else // SỬA
                {
                    if (loaiNhanSu == 2)
                    {
                        var gv = bindingSource.Current as GiangVien;
                        if (gv != null)
                        {
                            gv.MaSo = txtMaSo.Text.Trim();
                            gv.HoVaTen = txtHoVaTen.Text.Trim();
                            gv.NgaySinh = dtpNgaySinh.Value;
                            gv.GioiTinh = rdoNam.Checked;
                            gv.DiaChi = txtDiaChi.Text.Trim();
                            gv.Sdt = txtSdt.Text.Trim();
                            gv.Email = txtEmail.Text.Trim();
                            gv.BoPhan = txtBoPhan.Text.Trim();
                            if (!string.IsNullOrEmpty(fileNameHinhAnh)) gv.HinhAnh = fileNameHinhAnh;
                        }
                    }
                    else
                    {
                        var nv = bindingSource.Current as NhanVien;
                        if (nv != null)
                        {
                            nv.MaSo = txtMaSo.Text.Trim();
                            nv.HoVaTen = txtHoVaTen.Text.Trim();
                            nv.NgaySinh = dtpNgaySinh.Value;
                            nv.GioiTinh = rdoNam.Checked;
                            nv.DiaChi = txtDiaChi.Text.Trim();
                            nv.Sdt = txtSdt.Text.Trim();
                            nv.Email = txtEmail.Text.Trim();
                            nv.BoPhan = txtBoPhan.Text.Trim();
                            if (!string.IsNullOrEmpty(fileNameHinhAnh)) nv.HinhAnh = fileNameHinhAnh;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Cập nhật thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                fileNameHinhAnh = "";
                if (loaiNhanSu == 2) LoadGiangVien(); else LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanSu_Load(sender, e);
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

                if (open.ShowDialog() != DialogResult.OK) return;

                string fileName = open.SafeFileName;
                string destPath = System.IO.Path.Combine(folderAnh, fileName);

                try
                {
                    if (picHinhAnh.Image != null)
                    {
                        picHinhAnh.Image.Dispose();
                        picHinhAnh.Image = null;
                    }

                    if (!System.IO.File.Exists(destPath))
                    {
                        System.IO.File.Copy(open.FileName, destPath);
                    }

                    using (var stream = new System.IO.FileStream(destPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picHinhAnh.Image = Image.FromStream(stream);
                    }

                    if (bindingSource.Current == null) return;

                    if (loaiNhanSu == 2) // Giảng viên
                    {
                        var gv = bindingSource.Current as GiangVien;
                        if (gv != null)
                        {
                            gv.HinhAnh = fileName;
                        }
                    }
                    else // Nhân viên
                    {
                        var nv = bindingSource.Current as NhanVien;
                        if (nv != null)
                        {
                            nv.HinhAnh = fileName;
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xử lý ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current == null) return;

            string hinhAnh = "";
            bool gioiTinh = true;

            if (loaiNhanSu == 2) // Giảng viên
            {
                var gv = bindingSource.Current as GiangVien;
                if (gv == null) return;

                hinhAnh = gv.HinhAnh;
                gioiTinh = gv.GioiTinh;
            }
            else // Nhân viên
            {
                var nv = bindingSource.Current as NhanVien;
                if (nv == null) return;

                hinhAnh = nv.HinhAnh;
                gioiTinh = nv.GioiTinh;
            }

            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }

            if (!string.IsNullOrEmpty(hinhAnh))
            {
                string fullPath = System.IO.Path.Combine(folderAnh, hinhAnh);

                if (System.IO.File.Exists(fullPath))
                {
                    try
                    {
                        using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                        {
                            picHinhAnh.Image = Image.FromStream(stream);
                        }
                        return;
                    }
                    catch
                    {
                    }
                }
            }
            if (gioiTinh)
            {
                picHinhAnh.Image = Properties.Resources.nam_avatar;
            }
            else
            {
                picHinhAnh.Image = Properties.Resources.nu_avatar;
            }
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "GioiTinh" && e.Value != null)
            {
                if (e.Value is bool gioiTinh)
                {
                    e.Value = gioiTinh ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }
    }
}
