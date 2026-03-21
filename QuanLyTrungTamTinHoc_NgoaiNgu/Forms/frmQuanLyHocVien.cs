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
    public partial class frmQuanLyHocVien : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        BindingSource bindingSource = new BindingSource();
        int id;
        string folderAnh = @"D:\Project\ĐỒ ÁN - Lập trình quản lý\HinhNen\";
        string fileNameHinhAnh = "";

        bool temp = true;
        public frmQuanLyHocVien()
        {
            InitializeComponent();
        }
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            ThemCotXemChiTiet();
            BatTatCaChucNang(false);

            bindingSource.DataSource = typeof(HocVien);
            dataGridView.DataSource = bindingSource;

            bindingSource.CurrentChanged += bindingSource_CurrentChanged;

            LoadCbbKhoaHoc();

            if (cbbKhoaHoc.SelectedValue != null)
            {
                int idKhoa = (int)cbbKhoaHoc.SelectedValue;
                LoadCbbLopHoc(idKhoa);

                if (cbbLopHoc.SelectedValue != null)
                {
                    int idLop = (int)cbbLopHoc.SelectedValue;
                    LoadDataTheoLop(idLop);
                }
            }

            txtMaSo.DataBindings.Clear();
            txtMaSo.DataBindings.Add("Text", bindingSource, "MaSo", true, DataSourceUpdateMode.Never);

            dtpNgaySinh.DataBindings.Clear();
            var bindingNgaySinh = new Binding("Value", bindingSource, "NgaySinh", true, DataSourceUpdateMode.Never);
            dtpNgaySinh.DataBindings.Add(bindingNgaySinh);

            txtHoVaTen.DataBindings.Clear();
            txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", true, DataSourceUpdateMode.Never);


            rdoNam.DataBindings.Clear();
            rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            rdoNu.DataBindings.Clear();
            Binding bdNu = new Binding("Checked", bindingSource, "GioiTinh", true, DataSourceUpdateMode.Never);
            bdNu.Format += (s, args) => args.Value = !(bool)args.Value;
            rdoNu.DataBindings.Add(bdNu);


            var listTrangThai = new[] {
                new { ID = 1, Name = "Đang học" },
                new { ID = 2, Name = "Bảo lưu" },
                new { ID = 3, Name = "Đã tốt nghiệp" }
            };
            cbbTrangThai.DataSource = listTrangThai;
            cbbTrangThai.DisplayMember = "Name";
            cbbTrangThai.ValueMember = "ID";

            cbbTrangThai.DataBindings.Clear();
            cbbTrangThai.DataBindings.Add("SelectedValue", bindingSource, "TrangThai", true, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", true, DataSourceUpdateMode.Never);

            txtSdt.DataBindings.Clear();
            txtSdt.DataBindings.Add("Text", bindingSource, "Sdt", true, DataSourceUpdateMode.Never);

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email", true, DataSourceUpdateMode.Never);
        }
        public void BatTatCaChucNang(bool giaTri)
        {
            txtHoVaTen.Enabled = giaTri;
            txtMaSo.Enabled = giaTri;
            cbbTrangThai.Enabled = giaTri;
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
        public void LoadCbbKhoaHoc()
        {
            var kh = context.KhoaHoc.ToList();

            cbbKhoaHoc.DataSource = kh;
            cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
            cbbKhoaHoc.ValueMember = "ID"; ;
        }
        public void LoadCbbLopHoc(int id)
        {
            var lop = context.LopHoc.Where(x => x.KhoaHocID == id).ToList();

            cbbLopHoc.DataSource = lop;
            cbbLopHoc.DisplayMember = "TenLopHoc";
            cbbLopHoc.ValueMember = "ID";
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbKhoaHoc.SelectedValue != null && cbbKhoaHoc.SelectedValue is int)
            {
                id = (int)cbbKhoaHoc.SelectedValue;
                LoadCbbLopHoc(id);
            }
        }
        public void LoadDataTheoLop(int idLop)
        {
            var hv = context.HocPhi
                    .Where(x => x.LopHocID == idLop)
                    .Select(x => x.HocVien)
                    .Distinct()
                    .ToList();

            bindingSource.DataSource = hv;

            bindingSource_CurrentChanged(null, null);
        }
        public void LoadDataTheoMaSo()
        {
            string maSo = txtMaSoTimKiem.Text.Trim();

            var listHv = context.HocVien
                                .Where(x => x.MaSo == maSo)
                                .ToList();

            bindingSource.DataSource = listHv;
        }

        private void btnXacNhanBoLoc_Click(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue is int idLop)
            {
                var lop = context.LopHoc.FirstOrDefault(x => x.ID == idLop);

                if (lop != null)
                {
                    string tenLop = lop.TenLopHoc;
                    grbDataGrid.Text = "Danh sách sinh viên thuộc lớp " + tenLop;
                }

                LoadDataTheoLop(idLop);
            }
            txtMaSoTimKiem.Clear();
        }

        private void btnXacNhanTimKiem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMaSoTimKiem.Text))
            {
                LoadDataTheoMaSo();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Mã số học viên để tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaSoTimKiem.Focus();
            }

            btnThem.Enabled = false; // chặn thêm 
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

            if (dataGridView.Columns[e.ColumnIndex].Name == "TrangThai" && e.Value != null)
            {
                int status = (int)e.Value;
                switch (status)
                {
                    case 1: e.Value = "Đang học"; break;
                    case 2: e.Value = "Bảo lưu"; break;
                    case 3: e.Value = "Đã tốt nghiệp"; break;
                    default: e.Value = "Khác"; break;
                }
                e.FormattingApplied = true;
            }
        }
        private void ThemCotXemChiTiet()
        {
            if (dataGridView.Columns["XemChiTiet"] is DataGridViewLinkColumn linkCol)
            {
                linkCol.Text = "Xem chi tiết";
                linkCol.UseColumnTextForLinkValue = true;
                linkCol.LinkColor = Color.Blue;
                linkCol.ActiveLinkColor = Color.Red;
                linkCol.VisitedLinkColor = Color.Blue;
                linkCol.LinkBehavior = LinkBehavior.HoverUnderline;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                var hv = bindingSource.Current as HocVien;
                if (hv != null)
                {
                    frmThongTinCaNhan frm = new frmThongTinCaNhan(hv.ID, 3);
                    frm.ShowDialog();
                }
            }
        }
        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var hv = bindingSource.Current as HocVien;
            if (hv == null) return;

            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }

            if (!string.IsNullOrEmpty(hv.HinhAnh))
            {
                string fullPath = System.IO.Path.Combine(folderAnh, hv.HinhAnh);

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


            if (hv.GioiTinh == true)
            {
                picHinhAnh.Image = Properties.Resources.nam_avatar;
            }
            else
            {
                picHinhAnh.Image = Properties.Resources.nu_avatar;
            }
        }
        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

            if (open.ShowDialog() == DialogResult.OK)
            {

                if (picHinhAnh.Image != null)
                {
                    picHinhAnh.Image.Dispose();
                }


                picHinhAnh.Image = Image.FromFile(open.FileName);


                string fileName = open.SafeFileName;
                string destPath = System.IO.Path.Combine(folderAnh, fileName);

                try
                {

                    if (!System.IO.File.Exists(destPath))
                    {
                        System.IO.File.Copy(open.FileName, destPath);
                    }


                    var hv = bindingSource.Current as HocVien;
                    if (hv != null)
                    {
                        hv.HinhAnh = fileName;
                        context.SaveChanges();

                        MessageBox.Show("Cập nhật ảnh thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmQuanLySinhVien_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            temp = true;
            BatTatCaChucNang(true);

            txtMaSo.Clear();
            txtHoVaTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            rdoNam.Checked = true;
            cbbTrangThai.SelectedValue = 1;
            txtDiaChi.Clear();
            txtSdt.Clear();
            txtEmail.Clear();

            fileNameHinhAnh = "";
            if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
            picHinhAnh.Image = Properties.Resources.nam_avatar;

            txtMaSo.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một sinh viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            if (MessageBox.Show("Xác nhận xóa học viên " + txtHoVaTen.Text + "?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
                HocVien hv = context.HocVien.Find(id);

                if (hv != null)
                {
                    context.HocVien.Remove(hv);
                }
                context.SaveChanges();

                frmQuanLySinhVien_Load(sender, e);
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            temp = false;
            BatTatCaChucNang(true);
            txtMaSo.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
                MessageBox.Show("Vui lòng nhập mã số học viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
                MessageBox.Show("Vui lòng nhập họ và tên học viên?", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                try
                {
                    if (temp) // true
                    {
                        if (cbbLopHoc.SelectedValue == null)
                        {
                            MessageBox.Show("Vui lòng chọn Khoá học và Lớp học (ở phần Bộ lọc bên trái) để xếp lớp cho sinh viên trước khi Xác nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        int idLop = Convert.ToInt32(cbbLopHoc.SelectedValue);

                        // tạo tài khoản
                        TaiKhoan tk = new TaiKhoan();
                        tk.TenDN = txtMaSo.Text.Trim();
                        tk.MatKhau = "1";
                        tk.TrangThai = true;
                        tk.QuyenHan = 3;

                        context.TaiKhoan.Add(tk);
                        context.SaveChanges();

                        // tạo học viên
                        HocVien hv = new HocVien();
                        hv.MaSo = txtMaSo.Text.Trim();
                        hv.HoVaTen = txtHoVaTen.Text.Trim();
                        hv.NgaySinh = dtpNgaySinh.Value;
                        hv.GioiTinh = rdoNam.Checked ? true : false;
                        hv.TrangThai = 1; 
                        hv.HinhAnh = fileNameHinhAnh;
                        hv.TaiKhoanID = tk.ID;
                        hv.DiaChi = txtDiaChi.Text.Trim();
                        hv.Sdt = txtSdt.Text.Trim();
                        hv.Email = txtEmail.Text.Trim();

                        context.HocVien.Add(hv);
                        context.SaveChanges();

                        // ghi danh vào lớp
                        HocPhi hp = new HocPhi();
                        hp.HocVienID = hv.ID;
                        hp.LopHocID = idLop;

                        context.HocPhi.Add(hp);
                        context.SaveChanges();

                        MessageBox.Show("Thêm học viên và tự động cấp tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // false
                    {
                        if (dataGridView.CurrentRow == null)
                        {
                            MessageBox.Show("Vui lòng chọn một sinh viên để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        id = Convert.ToInt32(dataGridView.CurrentRow.Cells["colID"].Value.ToString());
                        HocVien hvEdit = context.HocVien.Find(id);

                        if (hvEdit != null)
                        {
                            hvEdit.MaSo = txtMaSo.Text.Trim();
                            hvEdit.HoVaTen = txtHoVaTen.Text.Trim();
                            hvEdit.NgaySinh = dtpNgaySinh.Value;
                            hvEdit.GioiTinh = rdoNam.Checked ? true : false;
                            hvEdit.TrangThai = Convert.ToInt32(cbbTrangThai.SelectedValue);
                            hvEdit.DiaChi = txtDiaChi.Text.Trim();
                            hvEdit.Sdt = txtSdt.Text.Trim();
                            hvEdit.Email = txtEmail.Text.Trim();

                            if (!string.IsNullOrEmpty(fileNameHinhAnh))
                            {
                                hvEdit.HinhAnh = fileNameHinhAnh;
                            }

                            context.SaveChanges();
                            MessageBox.Show("Cập nhật thông tin sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    fileNameHinhAnh = "";
                    BatTatCaChucNang(false);
                    frmQuanLySinhVien_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi xảy ra trong quá trình lưu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        // hiển thị danh sách sinh vien bảo luu, đã tốt nghiệp và đang học
        private void LoadDataNhanh(int s)
        {
            // 1 đang học, 2 đã tốt nghiệp, 3 bảo lưu
            var listHv = context.HocVien
                                .Where(x => x.TrangThai == s)
                                .ToList();

            bindingSource.DataSource = listHv;

            if (listHv.Count == 0)
            {
                picHinhAnh.Image = null;
            }
        }
        private void btnBaoLuu_Click(object sender, EventArgs e)
        {
            LoadDataNhanh(2);
            grbDataGrid.Text = "Danh sách sinh viên - BẢO LƯU";

            btnThem.Enabled = false; // chặn thêm vì không đang load tất cả
        }

        private void btnDaTotNghiep_Click(object sender, EventArgs e)
        {
            LoadDataNhanh(3);
            grbDataGrid.Text = "Danh sách sinh viên - ĐÃ TỐT NGHIỆP";

            btnThem.Enabled = false; // chặn thêm vì không đang load tất cả
        }

        private void btnDangHoc_Click(object sender, EventArgs e)
        {
            LoadDataNhanh(1);
            grbDataGrid.Text = "Danh sách sinh viên - ĐANG HỌC";

            btnThem.Enabled = false; // chặn thêm vì không đang load tất cả
        }
        
    }
}
