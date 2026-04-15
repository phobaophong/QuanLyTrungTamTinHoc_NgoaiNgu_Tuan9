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
using ClosedXML.Excel;

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

        int quyenHanDangNhap;
        public frmQuanLyHocVien(int quyenHan)
        {
            InitializeComponent();

            quyenHanDangNhap = quyenHan;

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            context = new QuanLyTrungTamContext();
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
            txtMaSo.Enabled = false;

            txtHoVaTen.Enabled = giaTri;
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

            if (!giaTri && (quyenHanDangNhap == 4 || quyenHanDangNhap == 1))
            {
                btnXoa.Visible = true;
            }
            else
            {
                btnXoa.Visible = false;
            }
        }
        public void LoadCbbKhoaHoc()
        {
            context = new QuanLyTrungTamContext();

            var kh = context.KhoaHoc.Where(k => k.HocPhi > 0).ToList();

            if (kh.Count > 0)
            {
                cbbKhoaHoc.DataSource = kh;
                cbbKhoaHoc.DisplayMember = "TenKhoaHoc";
                cbbKhoaHoc.ValueMember = "ID";
            }
            else
            {
                cbbKhoaHoc.DataSource = null;
                cbbKhoaHoc.Text = "Chưa có khóa học";
            }
        }
        public void LoadCbbLopHoc(int id)
        {
            context = new QuanLyTrungTamContext();
            var lop = context.LopHoc.Where(x => x.KhoaHocID == id).ToList();

            if (lop.Count > 0)
            {
                cbbLopHoc.DataSource = lop;
                cbbLopHoc.DisplayMember = "TenLopHoc";
                cbbLopHoc.ValueMember = "ID";
            }
            else
            {
                cbbLopHoc.DataSource = null;
                cbbLopHoc.Text = "Chưa có lớp học";

                dataGridView.DataSource = null;
            }
        }

        private void cbbKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            context = new QuanLyTrungTamContext();
            if (cbbKhoaHoc.SelectedValue != null && cbbKhoaHoc.SelectedValue is int)
            {
                id = (int)cbbKhoaHoc.SelectedValue;
                LoadCbbLopHoc(id);
            }

            btnThem.Enabled = true;
        }
        public void LoadDataTheoLop(int idLop)
        {
            context = new QuanLyTrungTamContext();
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
            context = new QuanLyTrungTamContext();
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
            btnThem.Enabled = true;
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
            // giới tính
            if (dataGridView.Columns[e.ColumnIndex].Name == "GioiTinh" && e.Value != null)
            {
                if (e.Value is bool gioiTinh)
                {
                    e.Value = gioiTinh ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }

            // trạng thái
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

            // hình ảnh
            if (dataGridView.Columns[e.ColumnIndex].Name == "HinhAnh")
            {
                var hv = dataGridView.Rows[e.RowIndex].DataBoundItem as HocVien;
                if (hv != null)
                {
                    Image img = null;

                    if (!string.IsNullOrEmpty(hv.HinhAnh))
                    {
                        string fullPath = System.IO.Path.Combine(folderAnh, hv.HinhAnh);
                        if (System.IO.File.Exists(fullPath))
                        {
                            try
                            {
                                using (var stream = new System.IO.FileStream(fullPath, System.IO.FileMode.Open, System.IO.FileAccess.Read))
                                {
                                    img = Image.FromStream(stream);
                                }
                            }
                            catch
                            {
                            }
                        }
                    }

                    if (img == null)
                    {
                        img = (hv.GioiTinh == true) ? Properties.Resources.nam_avatar : Properties.Resources.nu_avatar;
                    }

                    e.Value = img;
                    e.FormattingApplied = true;
                }
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

            int maxId = context.HocVien.Any() ? context.HocVien.Max(h => h.ID) : 0;
            txtMaSo.Text = "hv" + (maxId + 1).ToString("D2");

            txtHoVaTen.Clear();
            dtpNgaySinh.Value = DateTime.Now.Date;
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
                MessageBox.Show("Vui lòng chọn một học viên để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var hvHienTai = bindingSource.Current as HocVien;
            if (hvHienTai == null) return;

            using (frmXacNhanLaiMatKhau frm = new frmXacNhanLaiMatKhau(quyenHanDangNhap))
            {
                frm.ShowDialog();


                if (frm.XacNhanThanhCong)
                {

                    if (MessageBox.Show($"CẢNH BÁO: Bạn có chắc chắn muốn xóa học viên {txtHoVaTen.Text}?\n\nThao tác này sẽ xóa VĨNH VIỄN toàn bộ Tài khoản, Học phí, Lớp học và Điểm số của học viên này!", "Xác nhận xóa dữ liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            HocVien hv = context.HocVien.Find(hvHienTai.ID);

                            if (hv != null)
                            {
                                // Xóa Điểm số
                                var dsKetQua = context.KetQua.Where(k => k.HocVienID == hv.ID).ToList();
                                if (dsKetQua.Any())
                                {
                                    context.KetQua.RemoveRange(dsKetQua);
                                }

                                // Xóa Học phí
                                var dsHocPhi = context.HocPhi.Where(hp => hp.HocVienID == hv.ID).ToList();
                                if (dsHocPhi.Any())
                                {
                                    context.HocPhi.RemoveRange(dsHocPhi);
                                }

                                var idTaiKhoan = hv.TaiKhoanID;

                                // Xóa Học viên
                                context.HocVien.Remove(hv);

                                // Xóa Tài khoản
                                if (idTaiKhoan != null)
                                {
                                    var tk = context.TaiKhoan.Find(idTaiKhoan);
                                    if (tk != null)
                                    {
                                        context.TaiKhoan.Remove(tk);
                                    }
                                }

                                context.SaveChanges();

                                MessageBox.Show("Đã xóa sạch toàn bộ dữ liệu của học viên!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                // Reset lại giao diện sau khi xóa
                                BatTatCaChucNang(false);
                                txtHoVaTen.Clear();
                                txtMaSo.Clear();
                                txtDiaChi.Clear();
                                txtSdt.Clear();
                                txtEmail.Clear();
                                if (picHinhAnh.Image != null) picHinhAnh.Image.Dispose();
                                picHinhAnh.Image = Properties.Resources.nam_avatar;

                                frmQuanLySinhVien_Load(sender, e);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi khi xóa dữ liệu: " + ex.Message, "Lỗi cơ sở dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // Trượt mật khẩu hoặc bấm Hủy
                    MessageBox.Show("Thao tác xóa học viên đã bị hủy do chưa xác thực được quyền Quản trị!", "Bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void Sua_Click(object sender, EventArgs e)
        {
            temp = false;
            BatTatCaChucNang(true);
            txtHoVaTen.Focus();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            txtHoVaTen.Text = ChuanHoaChuoi(txtHoVaTen.Text);
            txtDiaChi.Text = ChuanHoaChuoi(txtDiaChi.Text);

            string hoTenNhap = txtHoVaTen.Text;
            string sdtNhap = txtSdt.Text.Trim();
            string emailNhap = txtEmail.Text.Trim();

            // 2. KIỂM TRA RỖNG CƠ BẢN
            if (string.IsNullOrWhiteSpace(txtMaSo.Text))
            {
                MessageBox.Show("Mã số học viên không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(hoTenNhap))
            {
                MessageBox.Show("Vui lòng nhập họ và tên học viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtHoVaTen.Focus();
                return;
            }

            // 3. KIỂM TRA ĐỊNH DẠNG SỐ ĐIỆN THOẠI (Bắt đầu bằng số 0, dài 10 chữ số, toàn là số)
            if (string.IsNullOrWhiteSpace(sdtNhap) || !sdtNhap.StartsWith("0") || sdtNhap.Length != 10 || !sdtNhap.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!\nVui lòng nhập đúng 10 chữ số và bắt đầu bằng số 0.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSdt.Focus();
                return;
            }

            // 4. KIỂM TRA ĐỊNH DẠNG EMAIL (Nếu có nhập thì phải nhập đúng định dạng @gmail.com)
            if (!string.IsNullOrWhiteSpace(emailNhap))
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(emailNhap);
                    if (addr.Address != emailNhap) throw new Exception();
                }
                catch
                {
                    MessageBox.Show("Định dạng Email không hợp lệ!\nVí dụ đúng: nguyenvan@gmail.com", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEmail.Focus();
                    return;
                }
            }

            // 5. KIỂM TRA ĐỘ TUỔI
            int tuoi = DateTime.Now.Year - dtpNgaySinh.Value.Year;
            if (DateTime.Now.DayOfYear < dtpNgaySinh.Value.DayOfYear)
            {
                tuoi--;
            }

            if (tuoi < 5 || tuoi > 100)
            {
                MessageBox.Show($"Ngày sinh không hợp lệ! Tuổi hiện tại đang là {tuoi}.\nHọc viên trung tâm phải nằm trong độ tuổi từ 5 đến 100 tuổi.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return;
            }

            try
            {
                if (temp) // THÊM MỚI
                {
                    if (cbbLopHoc.SelectedValue == null)
                    {
                        MessageBox.Show("Vui lòng chọn Khoá học và Lớp học (ở phần Bộ lọc bên trái) để xếp lớp cho sinh viên trước khi Xác nhận!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int idLop = Convert.ToInt32(cbbLopHoc.SelectedValue);

                    // kiểm tra hv cũ quay lại học
                    bool gioiTinhNhap = rdoNam.Checked;
                    DateTime ngaySinhNhap = dtpNgaySinh.Value.Date;

                    var hvCu = context.HocVien.FirstOrDefault(h =>
                        h.HoVaTen == hoTenNhap &&
                        h.NgaySinh.Date == ngaySinhNhap &&
                        h.GioiTinh == gioiTinhNhap);

                    if (hvCu != null)
                    {
                        bool daHocLopNay = context.HocPhi.Any(hp => hp.HocVienID == hvCu.ID && hp.LopHocID == idLop);
                        if (daHocLopNay)
                        {
                            MessageBox.Show($"Học viên {hoTenNhap} (Sinh ngày: {ngaySinhNhap:dd/MM/yyyy}) đã có tên trong lớp {cbbLopHoc.Text} từ trước rồi!", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string tbCapNhatSdt = "";
                        if (hvCu.Sdt != sdtNhap)
                        {
                            hvCu.Sdt = sdtNhap;
                            tbCapNhatSdt = $"\n- Đã tự động cập nhật số điện thoại mới: {sdtNhap}";
                        }

                        HocPhi hpMoi = new HocPhi();
                        hpMoi.HocVienID = hvCu.ID;
                        hpMoi.LopHocID = idLop;
                        hpMoi.NgayDong = DateTime.Now;

                        context.HocPhi.Add(hpMoi);
                        hvCu.TrangThai = 1;

                        context.SaveChanges();

                        MessageBox.Show($"Phát hiện học viên cũ: {hoTenNhap}.\n- Hệ thống đã tự động ghi danh vào lớp mới.{tbCapNhatSdt}\n(Không tạo dư thừa tài khoản mới)", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // học viên mới
                        TaiKhoan tk = new TaiKhoan();
                        tk.TenDN = txtMaSo.Text.Trim();
                        tk.MatKhau = BC.HashPassword("1");
                        tk.TrangThai = true;
                        tk.QuyenHan = 3;

                        context.TaiKhoan.Add(tk);
                        context.SaveChanges();

                        HocVien hv = new HocVien();
                        hv.MaSo = txtMaSo.Text.Trim();
                        hv.HoVaTen = hoTenNhap; 
                        hv.NgaySinh = dtpNgaySinh.Value.Date;
                        hv.GioiTinh = rdoNam.Checked ? true : false;
                        hv.TrangThai = 1;
                        hv.HinhAnh = fileNameHinhAnh;
                        hv.TaiKhoanID = tk.ID;
                        hv.DiaChi = txtDiaChi.Text.Trim(); 
                        hv.Sdt = sdtNhap;
                        hv.Email = emailNhap;

                        context.HocVien.Add(hv);
                        context.SaveChanges();

                        HocPhi hp = new HocPhi();
                        hp.HocVienID = hv.ID;
                        hp.LopHocID = idLop;
                        hp.NgayDong = DateTime.Now;

                        context.HocPhi.Add(hp);
                        context.SaveChanges();

                        MessageBox.Show("Thêm học viên mới và tự động cấp tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else // SỬA
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
                        hvEdit.HoVaTen = hoTenNhap; 
                        hvEdit.NgaySinh = dtpNgaySinh.Value.Date;
                        hvEdit.GioiTinh = rdoNam.Checked ? true : false;
                        hvEdit.TrangThai = Convert.ToInt32(cbbTrangThai.SelectedValue);
                        hvEdit.DiaChi = txtDiaChi.Text.Trim(); 
                        hvEdit.Sdt = sdtNhap;
                        hvEdit.Email = emailNhap;

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


        // hiển thị danh sách sinh vien bảo luu, đã tốt nghiệp và đang học
        private void LoadDataNhanh(int s)
        {
            context = new QuanLyTrungTamContext();
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

            btnThem.Enabled = false; // chặn thêm 
        }

        private void btnDaTotNghiep_Click(object sender, EventArgs e)
        {
            LoadDataNhanh(3);
            grbDataGrid.Text = "Danh sách sinh viên - ĐÃ TỐT NGHIỆP";

            btnThem.Enabled = false; // chặn thêm 
        }

        private void btnDangHoc_Click(object sender, EventArgs e)
        {
            LoadDataNhanh(1);
            grbDataGrid.Text = "Danh sách sinh viên - ĐANG HỌC";

            btnThem.Enabled = false; // chặn thêm 
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Khoá học và Lớp học (ở phần Bộ lọc) để biết sẽ xếp học viên vào lớp nào trước khi Nhập Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idLopDuocChon = (int)cbbLopHoc.SelectedValue;

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Nhập danh sách từ Excel";
            openDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtData = new DataTable();

                    using (XLWorkbook wb = new XLWorkbook(openDialog.FileName))
                    {
                        IXLWorksheet ws = wb.Worksheet(1);
                        bool isHeader = true;
                        string vungDoc = "1:1";

                        foreach (IXLRow dong in ws.RowsUsed())
                        {
                            if (isHeader)
                            {
                                vungDoc = string.Format("{0}:{1}", 1, dong.LastCellUsed().Address.ColumnNumber);
                                foreach (IXLCell oDuLieu in dong.Cells(vungDoc))
                                {
                                    dtData.Columns.Add(oDuLieu.Value.ToString());
                                }
                                isHeader = false;
                            }
                            else
                            {
                                dtData.Rows.Add();
                                int viTriCot = 0;
                                foreach (IXLCell oDuLieu in dong.Cells(vungDoc))
                                {
                                    dtData.Rows[dtData.Rows.Count - 1][viTriCot] = oDuLieu.Value.ToString();
                                    viTriCot++;
                                }
                            }
                        }
                    }

                    int demThanhCongMoi = 0;
                    int demThanhCongCu = 0;
                    int demBoQua = 0;

                    int maxId = context.HocVien.Any() ? context.HocVien.Max(h => h.ID) : 0;

                    foreach (DataRow dRow in dtData.Rows)
                    {
                        string hoTen = dRow.Table.Columns.Count > 1 ? dRow[1].ToString().Trim() : "";
                        string sdt = dRow.Table.Columns.Count > 4 ? dRow[4].ToString().Trim() : "";

                        if (string.IsNullOrEmpty(hoTen))
                        {
                            demBoQua++;
                            continue;
                        }

                        DateTime ngaySinh;
                        if (dRow.Table.Columns.Count <= 2 || !DateTime.TryParse(dRow[2].ToString(), out ngaySinh))
                        {
                            ngaySinh = DateTime.Now.Date; 
                        }

                        string strGioiTinh = dRow.Table.Columns.Count > 3 ? dRow[3].ToString().Trim().ToLower() : "nam";
                        bool gioiTinh = (strGioiTinh == "nam" || strGioiTinh == "1" || strGioiTinh == "true");

                        var hvCu = context.HocVien.FirstOrDefault(h =>
                            h.HoVaTen == hoTen &&
                            h.NgaySinh.Date == ngaySinh.Date &&
                            h.GioiTinh == gioiTinh);

                        if (hvCu != null)
                        {

                            bool daHocLopNay = context.HocPhi.Any(hp => hp.HocVienID == hvCu.ID && hp.LopHocID == idLopDuocChon);
                            if (daHocLopNay)
                            {
                                demBoQua++;
                                continue;
                            }

                            if (!string.IsNullOrEmpty(sdt) && hvCu.Sdt != sdt)
                            {
                                hvCu.Sdt = sdt;
                            }

                            HocPhi hpMoi = new HocPhi();
                            hpMoi.LopHocID = idLopDuocChon;
                            hpMoi.HocVienID = hvCu.ID;
                            hpMoi.NgayDong = DateTime.Now;

                            hvCu.TrangThai = 1; 
                            context.HocPhi.Add(hpMoi);

                            demThanhCongCu++;
                        }
                        else
                        {
   
                            maxId++;
                            string maSoMoi = "hv" + maxId.ToString("D2");

                            TaiKhoan taiKhoanMoi = new TaiKhoan();
                            taiKhoanMoi.TenDN = maSoMoi;
                            taiKhoanMoi.MatKhau = BC.HashPassword("1");
                            taiKhoanMoi.TrangThai = true;
                            taiKhoanMoi.QuyenHan = 3;

                            HocVien hocVienMoi = new HocVien();
                            hocVienMoi.MaSo = maSoMoi;


                            hocVienMoi.HoVaTen = ChuanHoaChuoi(hoTen);
                            hocVienMoi.NgaySinh = ngaySinh.Date;
                            hocVienMoi.GioiTinh = gioiTinh;
                            hocVienMoi.Sdt = sdt;

                            hocVienMoi.DiaChi = dRow.Table.Columns.Count > 5 ? ChuanHoaChuoi(dRow[5].ToString()) : "";
                            hocVienMoi.Email = dRow.Table.Columns.Count > 6 ? dRow[6].ToString().Trim() : "";

                            hocVienMoi.TrangThai = 1;
                            hocVienMoi.TaiKhoan = taiKhoanMoi;

                            HocPhi hocPhiMoi = new HocPhi();
                            hocPhiMoi.LopHocID = idLopDuocChon;
                            hocPhiMoi.HocVien = hocVienMoi;
                            hocPhiMoi.NgayDong = DateTime.Now;

                            context.TaiKhoan.Add(taiKhoanMoi);
                            context.HocVien.Add(hocVienMoi);
                            context.HocPhi.Add(hocPhiMoi);

                            demThanhCongMoi++;
                        }
                    }

                    context.SaveChanges();

                    MessageBox.Show($"Kết quả Nhập Excel:\n- Đã tạo MỚI và xếp lớp cho {demThanhCongMoi} học viên.\n- Đã ghi danh {demThanhCongCu} học viên CŨ vào lớp.\n- Bỏ qua {demBoQua} dòng (trống hoặc học viên đã có sẵn trong lớp này).", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoadDataTheoLop(idLopDuocChon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi đọc file Excel: " + ex.Message, "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            string tenLop = "TatCa";
            if (cbbLopHoc.SelectedValue != null && !string.IsNullOrWhiteSpace(cbbLopHoc.Text))
            {
                tenLop = cbbLopHoc.Text.Trim();

                // Loại bỏ các ký tự đặc biệt không được phép đặt tên file trong Windows (VD: \ / : * ? " < > |)
                foreach (char c in System.IO.Path.GetInvalidFileNameChars())
                {
                    tenLop = tenLop.Replace(c.ToString(), "_");
                }
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Xuất danh sách học viên ra Excel";
            saveDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";

            saveDialog.FileName = $"DanhSachHocVien_{tenLop}_{DateTime.Now.ToString("dd_MM_yyyy")}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtHocVien = new DataTable();
                    dtHocVien.Columns.Add("Mã số", typeof(string));
                    dtHocVien.Columns.Add("Họ và tên", typeof(string));
                    dtHocVien.Columns.Add("Ngày sinh", typeof(DateTime));
                    dtHocVien.Columns.Add("Giới tính", typeof(string));
                    dtHocVien.Columns.Add("SĐT", typeof(string));
                    dtHocVien.Columns.Add("Địa chỉ", typeof(string));
                    dtHocVien.Columns.Add("Email", typeof(string));

                    foreach (DataGridViewRow row in dataGridView.Rows)
                    {
                        var hocVien = row.DataBoundItem as HocVien;
                        if (hocVien != null)
                        {
                            string phai = hocVien.GioiTinh ? "Nam" : "Nữ";
                            dtHocVien.Rows.Add(hocVien.MaSo, hocVien.HoVaTen, hocVien.NgaySinh, phai, hocVien.Sdt, hocVien.DiaChi, hocVien.Email);
                        }
                    }

                    using (XLWorkbook excelWorkbook = new XLWorkbook())
                    {
                        var excelSheet = excelWorkbook.Worksheets.Add(dtHocVien, "HocVien");
                        excelSheet.Column(3).Style.DateFormat.Format = "dd/MM/yyyy";
                        excelSheet.Columns().AdjustToContents();
                        excelWorkbook.SaveAs(saveDialog.FileName);

                        MessageBox.Show($"Đã xuất danh sách lớp {tenLop} ra file Excel thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private string ChuanHoaChuoi(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return "";

            input = input.Trim();
            // Xóa khoảng trắng thừa ở giữa các từ
            input = System.Text.RegularExpressions.Regex.Replace(input, @"\s+", " ");

            // Ép viết hoa chữ cái đầu
            System.Globalization.CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            System.Globalization.TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(input.ToLower());
        }
    }
}
