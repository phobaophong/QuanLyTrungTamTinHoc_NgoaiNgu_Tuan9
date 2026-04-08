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
        int quyenHanDangNhap;

        public frmQuanLyNhanSu(int quyenHan)
        {
            InitializeComponent();
            quyenHanDangNhap = quyenHan;
            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        public void BatTatCaChucNang(bool giaTri)
        {
            txtHoVaTen.Enabled = giaTri;
            txtMaSo.Enabled = false;
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
            btnSua.Enabled = !giaTri;
            btnDoiAnh.Enabled = giaTri;

            // Khóa lưới DataGrid khi đang chỉnh sửa
            dataGridView.Enabled = !giaTri;

            if (!giaTri && quyenHanDangNhap == 4)
            {
                btnXoa.Visible = true;
                btnXoa.Enabled = true;
            }
            else
            {
                btnXoa.Visible = false;
                btnXoa.Enabled = false;
            }
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            LoadGiangVien();
            btnThem.Text = "Thêm Giảng Viên";
            groupBox1.Text = "Thông tin giảng viên";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            LoadNhanVien();
            btnThem.Text = "Thêm Nhân Viên";
            groupBox1.Text = "Thông tin nhân viên";
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
        private void LoadGiangVien()
        {
            context = new QuanLyTrungTamContext();
            loaiNhanSu = 2;
            var gv = context.GiangVien.ToList();

            txtHoVaTen.DataBindings.Clear();
            txtMaSo.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtBoPhan.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            rdoNam.DataBindings.Clear();
            rdoNu.DataBindings.Clear();

            bindingSource.DataSource = gv;

            if (gv.Count > 0)
            {
                txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                txtMaSo.DataBindings.Add("Text", bindingSource, "MaSo", false, DataSourceUpdateMode.Never);
                txtSdt.DataBindings.Add("Text", bindingSource, "Sdt", false, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
                txtBoPhan.DataBindings.Add("Text", bindingSource, "BoPhan", false, DataSourceUpdateMode.Never);

                var bindingNgaySinh = new Binding("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
                dtpNgaySinh.DataBindings.Add(bindingNgaySinh);

                rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);

                Binding bdNu = new Binding("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
                bdNu.Format += (s, args) =>
                {
                    if (args.Value != null && args.Value != DBNull.Value)
                    {
                        args.Value = !(bool)args.Value;
                    }
                };
                rdoNu.DataBindings.Add(bdNu);
            }
            else
            {
                txtMaSo.Clear();
                txtHoVaTen.Clear();
                txtDiaChi.Clear();
                txtSdt.Clear();
                txtEmail.Clear();
                txtBoPhan.Clear();
                if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
                picHinhAnh.Image = Properties.Resources.nam_avatar;
            }

            dataGridView.DataSource = bindingSource;
            BatTatCaChucNang(false);
        }

        private void LoadNhanVien()
        {
            context = new QuanLyTrungTamContext();
            loaiNhanSu = 1;
            var nv = context.NhanVien.ToList();

            txtHoVaTen.DataBindings.Clear();
            txtMaSo.DataBindings.Clear();
            txtSdt.DataBindings.Clear();
            txtDiaChi.DataBindings.Clear();
            txtEmail.DataBindings.Clear();
            txtBoPhan.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Clear();
            rdoNam.DataBindings.Clear();
            rdoNu.DataBindings.Clear();

            bindingSource.DataSource = nv;

            if (nv.Count > 0)
            {
                txtHoVaTen.DataBindings.Add("Text", bindingSource, "HoVaTen", false, DataSourceUpdateMode.Never);
                txtMaSo.DataBindings.Add("Text", bindingSource, "MaSo", false, DataSourceUpdateMode.Never);
                txtSdt.DataBindings.Add("Text", bindingSource, "Sdt", false, DataSourceUpdateMode.Never);
                txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi", false, DataSourceUpdateMode.Never);
                txtEmail.DataBindings.Add("Text", bindingSource, "Email", false, DataSourceUpdateMode.Never);
                txtBoPhan.DataBindings.Add("Text", bindingSource, "BoPhan", false, DataSourceUpdateMode.Never);

                var bindingNgaySinh = new Binding("Value", bindingSource, "NgaySinh", false, DataSourceUpdateMode.Never);
                dtpNgaySinh.DataBindings.Add(bindingNgaySinh);

                rdoNam.DataBindings.Add("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);

                Binding bdNu = new Binding("Checked", bindingSource, "GioiTinh", false, DataSourceUpdateMode.Never);
                bdNu.Format += (s, args) =>
                {
                    if (args.Value != null && args.Value != DBNull.Value)
                    {
                        args.Value = !(bool)args.Value;
                    }
                };
                rdoNu.DataBindings.Add(bdNu);
            }
            else
            {
                txtMaSo.Clear();
                txtHoVaTen.Clear();
                txtDiaChi.Clear();
                txtSdt.Clear();
                txtEmail.Clear();
                txtBoPhan.Clear();
                if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
                picHinhAnh.Image = Properties.Resources.nam_avatar;
            }

            dataGridView.DataSource = bindingSource;
            BatTatCaChucNang(false);
        }

        private void frmQuanLyNhanSu_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            ThemCotXemChiTiet();
            dataGridView.AutoGenerateColumns = false;
            LoadGiangVien(); // Mặc định vào sẽ load Giảng viên
            bindingSource.CurrentChanged += bindingSource_CurrentChanged;

            if (dataGridView.Columns.Contains("NgaySinh"))
            {
                dataGridView.Columns["NgaySinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            temp = true;
            BatTatCaChucNang(true);

            int maxId = 0;
            string prefix = "";

            if (loaiNhanSu == 2)
            {
                maxId = context.GiangVien.Any() ? context.GiangVien.Max(g => g.ID) : 0;
                prefix = "gv";
            }
            else
            {
                maxId = context.NhanVien.Any() ? context.NhanVien.Max(n => n.ID) : 0;
                prefix = "nv";
            }

            string maMoi = prefix + (maxId + 1).ToString("D2");
            while (context.TaiKhoan.Any(t => t.TenDN == maMoi))
            {
                maxId++;
                maMoi = prefix + (maxId + 1).ToString("D2");
            }

            txtMaSo.Text = maMoi;

            txtHoVaTen.Clear();
            dtpNgaySinh.Value = DateTime.Now.Date;
            rdoNam.Checked = true;
            txtDiaChi.Clear();
            txtSdt.Clear();
            txtEmail.Clear();
            txtBoPhan.Clear();

            fileNameHinhAnh = "";
            if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
            picHinhAnh.Image = Properties.Resources.nam_avatar;

            txtHoVaTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null) return;

            if (MessageBox.Show($"Xác nhận xóa {txtHoVaTen.Text}?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int? idTaiKhoanCanXoa = null;

                if (loaiNhanSu == 2) // Giảng viên
                {
                    var gv = bindingSource.Current as GiangVien;
                    if (gv != null)
                    {
                        idTaiKhoanCanXoa = gv.TaiKhoanID;
                        context.GiangVien.Remove(gv);
                    }
                }
                else // Nhân viên
                {
                    var nv = bindingSource.Current as NhanVien;
                    if (nv != null)
                    {
                        idTaiKhoanCanXoa = nv.TaiKhoanID;
                        context.NhanVien.Remove(nv);
                    }
                }

                if (idTaiKhoanCanXoa != null)
                {
                    var tk = context.TaiKhoan.Find(idTaiKhoanCanXoa);
                    if (tk != null) context.TaiKhoan.Remove(tk);
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
            txtHoVaTen.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
            {
                MessageBox.Show("Vui lòng nhập mã số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtHoVaTen.Text))
            {
                MessageBox.Show("Vui lòng nhập họ và tên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
                return;
            }

            try
            {
                if (temp) // THÊM MỚI
                {
                    string maMoi = txtMaSo.Text.Trim();
                    bool trungTK = context.TaiKhoan.Any(t => t.TenDN == maMoi);
                    if (trungTK)
                    {
                        MessageBox.Show("Mã số này đã tồn tại trên hệ thống! Vui lòng chọn mã khác.", "Trùng dữ liệu");
                        return;
                    }

                    TaiKhoan tk = new TaiKhoan();
                    tk.TenDN = maMoi;
                    tk.MatKhau = BC.HashPassword("1");
                    tk.TrangThai = true;
                    tk.QuyenHan = loaiNhanSu;

                    context.TaiKhoan.Add(tk);

                    if (loaiNhanSu == 2)
                    {
                        GiangVien gv = new GiangVien();
                        gv.MaSo = maMoi;
                        gv.HoVaTen = txtHoVaTen.Text.Trim();
                        gv.NgaySinh = dtpNgaySinh.Value.Date;
                        gv.GioiTinh = rdoNam.Checked;
                        gv.DiaChi = txtDiaChi.Text.Trim();
                        gv.Sdt = txtSdt.Text.Trim();
                        gv.Email = txtEmail.Text.Trim();
                        gv.BoPhan = txtBoPhan.Text.Trim();
                        gv.HinhAnh = fileNameHinhAnh;
                        gv.TaiKhoan = tk;

                        context.GiangVien.Add(gv);
                    }
                    else
                    {
                        NhanVien nv = new NhanVien();
                        nv.MaSo = maMoi;
                        nv.HoVaTen = txtHoVaTen.Text.Trim();
                        nv.NgaySinh = dtpNgaySinh.Value.Date;
                        nv.GioiTinh = rdoNam.Checked;
                        nv.DiaChi = txtDiaChi.Text.Trim();
                        nv.Sdt = txtSdt.Text.Trim();
                        nv.Email = txtEmail.Text.Trim();
                        nv.BoPhan = txtBoPhan.Text.Trim();
                        nv.HinhAnh = fileNameHinhAnh;
                        nv.TaiKhoan = tk;

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
                            gv.NgaySinh = dtpNgaySinh.Value.Date;
                            gv.GioiTinh = rdoNam.Checked;
                            gv.DiaChi = txtDiaChi.Text.Trim();
                            gv.Sdt = txtSdt.Text.Trim();
                            gv.Email = txtEmail.Text.Trim();
                            gv.BoPhan = txtBoPhan.Text.Trim();

                            // Có đổi ảnh mới thì cập nhật, không thì giữ nguyên ảnh cũ
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
                            nv.NgaySinh = dtpNgaySinh.Value.Date;
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

                fileNameHinhAnh = ""; // Reset sau khi lưu
                if (loaiNhanSu == 2) LoadGiangVien(); else LoadNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            fileNameHinhAnh = ""; // Hủy đổi ảnh
            if (loaiNhanSu == 2) LoadGiangVien();
            else LoadNhanVien();
        }

        private void btnDoiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open = new OpenFileDialog())
            {
                open.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";

                if (open.ShowDialog() != DialogResult.OK) return;

                string extension = System.IO.Path.GetExtension(open.SafeFileName);
                string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
                string fileName = "NhanSu_" + timestamp + extension;
                string destPath = System.IO.Path.Combine(folderAnh, fileName);

                try
                {
                    System.IO.File.Copy(open.FileName, destPath, true);

                    if (picHinhAnh.Image != null)
                    {
                        picHinhAnh.Image.Dispose();
                        picHinhAnh.Image = null;
                    }

                    // 🔥 SỬA LỖI ĐỘT TỬ GDI+ WINFORMS: Ép kiểu sang Bitmap
                    using (var stream = new System.IO.FileStream(destPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                    {
                        picHinhAnh.Image = new Bitmap(stream);
                    }

                    // Chỉ gán tên file, ĐỢI BẤM NÚT XÁC NHẬN MỚI LƯU DB
                    fileNameHinhAnh = fileName;

                    MessageBox.Show("Đã tải ảnh lên! Vui lòng bấm nút Xác Nhận để lưu thay đổi.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (loaiNhanSu == 2)
            {
                var gv = bindingSource.Current as GiangVien;
                if (gv == null) return;

                hinhAnh = gv.HinhAnh;
                gioiTinh = gv.GioiTinh;
            }
            else
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
                            picHinhAnh.Image = new Bitmap(stream); // 🔥 SỬA LỖI GDI+
                        }
                        return;
                    }
                    catch { }
                }
            }

            if (gioiTinh) picHinhAnh.Image = Properties.Resources.nam_avatar;
            else picHinhAnh.Image = Properties.Resources.nu_avatar;
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

            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                var dataItem = dataGridView.Rows[e.RowIndex].DataBoundItem;
                if (dataItem == null) return;

                string hinhAnh = "";
                bool gioiTinh = true;

                if (dataItem is GiangVien gv)
                {
                    hinhAnh = gv.HinhAnh;
                    gioiTinh = gv.GioiTinh;
                }
                else if (dataItem is NhanVien nv)
                {
                    hinhAnh = nv.HinhAnh;
                    gioiTinh = nv.GioiTinh;
                }
                else return;

                Image img = null;
                if (!string.IsNullOrEmpty(hinhAnh))
                {
                    string fullPath = System.IO.Path.Combine(folderAnh, hinhAnh);
                    if (System.IO.File.Exists(fullPath))
                    {
                        try
                        {
                            using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                            {
                                img = new Bitmap(stream); // 🔥 SỬA LỖI GDI+
                            }
                        }
                        catch { }
                    }
                }

                if (img == null) img = gioiTinh ? Properties.Resources.nam_avatar : Properties.Resources.nu_avatar;

                e.Value = img;
                e.FormattingApplied = true;
            }
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridView.Columns[e.ColumnIndex].Name == "XemChiTiet")
            {
                if (loaiNhanSu == 2) // Nếu đang ở tab Giảng viên
                {
                    var gv = bindingSource.Current as GiangVien;
                    if (gv != null)
                    {
                        frmThongTinCaNhan frm = new frmThongTinCaNhan(gv.ID, 2);
                        frm.ShowDialog();
                    }
                }
                else // Nếu đang ở tab Nhân viên
                {
                    var nv = bindingSource.Current as NhanVien;
                    if (nv != null)
                    {
                        frmThongTinCaNhan frm = new frmThongTinCaNhan(nv.ID, 1);
                        frm.ShowDialog();
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}