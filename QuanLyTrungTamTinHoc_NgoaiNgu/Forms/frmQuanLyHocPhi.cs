using ClosedXML.Excel;
using Microsoft.EntityFrameworkCore;
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
    public partial class frmQuanLyHocPhi : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();
        int id;
        int idPhieuThu = -1;
        decimal hocPhiKhoaHoc = 0;
        public frmQuanLyHocPhi()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmHocPhi_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;
            LoadCbbKhoaHoc();
        }
        private void BatTatCaChucNang(bool giaTri)
        {
            txtSoTien.Enabled = giaTri;
            dtpNgayDong.Enabled = giaTri;
            chkTrangThai.Enabled = giaTri;

            btnXacNhan.Enabled = giaTri;
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

        private void cbbLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue != null && cbbLopHoc.SelectedValue is int idLop)
            {
                id = idLop;

                var hpKhoaHoc = context.LopHoc
                   .Include(l => l.KhoaHoc)
                   .Where(l => l.ID == idLop)
                   .Select(l => l.KhoaHoc.HocPhi)
                   .FirstOrDefault();

                hocPhiKhoaHoc = hpKhoaHoc;

                lblHocPhi.Text = $"Học phí: {hocPhiKhoaHoc:N0} VNĐ";

                LoadDanhSachHocPhi(idLop);
            }
        }

        private void LoadDanhSachHocPhi(int idLop)
        {
            context = new QuanLyTrungTamContext();

            var query = context.HocPhi
                .Include(hp => hp.HocVien)
                .Include(hp => hp.LopHoc)
                .Where(hp => hp.LopHocID == idLop)
                .ToList();

            var danhSachHienThi = query.Select(hp => new DanhSachHocPhi_ChiTiet
            {
                ID = hp.ID,
                HocVienID = hp.HocVienID,
                HoVaTen = hp.HocVien?.HoVaTen,
                LopHocID = hp.LopHocID,
                TenLop = hp.LopHoc?.TenLopHoc,
                SoTienDaDong = hp.SoTienDaDong,
                NgayDong = hp.NgayDong,

                GhiChu = hp.SoTienDaDong >= hocPhiKhoaHoc ? "Đã đóng đủ" : (hp.SoTienDaDong > 0 ? "Đang nợ" : "Chưa đóng")
            }).ToList();


            dataGridView.DataSource = danhSachHienThi;

            foreach (DataGridViewColumn col in dataGridView.Columns)
            {
                if (col.DataPropertyName == "NgayDong")
                {
                    col.DefaultCellStyle.Format = "dd/MM/yyyy";
                }
            }

            BatTatCaChucNang(false);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                BatTatCaChucNang(true);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng học phí để sửa!", "Thông báo");
            }
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                var item = dataGridView.CurrentRow.DataBoundItem as DanhSachHocPhi_ChiTiet;
                if (item != null)
                {
                    idPhieuThu = item.ID;

                    txtHoVaTen.Text = item.HoVaTen;
                    txtSoTien.Text = item.SoTienDaDong.ToString("N0");
                    txtTenLop.Text = item.TenLop;
                    if (item.NgayDong.Year < 1753)
                    {
                        dtpNgayDong.Value = DateTime.Now;
                    }
                    else
                    {
                        dtpNgayDong.Value = item.NgayDong;
                    }

                    chkTrangThai.Checked = (item.GhiChu == "Đã đóng đủ");


                    BatTatCaChucNang(false);
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                var phieuThu = context.HocPhi.Find(idPhieuThu);

                if (phieuThu != null)
                {
                    // Lọc bỏ dấu phẩy/chấm ngàn trước khi Parse (Ví dụ: 2,500,000 -> 2500000)
                    string soTienText = txtSoTien.Text.Replace(",", "").Replace(".", "");

                    if (decimal.TryParse(soTienText, out decimal soTien))
                    {
                        if (soTien > hocPhiKhoaHoc)
                        {
                            MessageBox.Show($"Số tiền nhập vào ({soTien:N0} VNĐ) không được vượt quá mức học phí quy định của khóa học ({hocPhiKhoaHoc:N0} VNĐ)!\n\nVui lòng kiểm tra lại để tránh sai sót doanh thu.", "Lỗi vượt hạn mức", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSoTien.Focus();
                            return; // Dừng lại ngay lập tức, không chạy tiếp xuống dưới
                        }

                        phieuThu.SoTienDaDong = soTien;
                    }
                    else
                    {
                        MessageBox.Show("Số tiền không hợp lệ! Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtSoTien.Focus();
                        return;
                    }

                    phieuThu.NgayDong = dtpNgayDong.Value.Date;

                    phieuThu.TrangThai = (phieuThu.SoTienDaDong >= hocPhiKhoaHoc);

                    try
                    {
                        context.SaveChanges();
                        MessageBox.Show("Cập nhật học phí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        BatTatCaChucNang(false);

                        if (cbbLopHoc.SelectedValue is int idLop)
                        {
                            LoadDanhSachHocPhi(idLop);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Có lỗi xảy ra khi lưu: " + ex.Message, "Lỗi DB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtSoTien_TextChanged(object sender, EventArgs e)
        {
            if (txtSoTien.Enabled)
            {
                string soTienText = txtSoTien.Text.Replace(",", "").Replace(".", "");

                if (decimal.TryParse(soTienText, out decimal soTien))
                {
                    chkTrangThai.Checked = soTien >= hocPhiKhoaHoc;

                    if (soTien > 0)
                    {
                        dtpNgayDong.Value = DateTime.Now.Date;
                    }
                }
                else
                {
                    chkTrangThai.Checked = false;
                }
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            if (idPhieuThu != -1)
            {
                using (frmInBienLaiHocPhi frmIn = new frmInBienLaiHocPhi(idPhieuThu))
                {
                    frmIn.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một học viên trên danh sách để in biên lai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNhapExcel_Click(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Lớp học ở phần Bộ lọc trước khi nhập file Excel!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int idLopDuocChon = (int)cbbLopHoc.SelectedValue;

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Title = "Nhập danh sách học phí từ Excel";
            openDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    int demThanhCong = 0;
                    int demBoQua = 0;

                    using (XLWorkbook wb = new XLWorkbook(openDialog.FileName))
                    {
                        IXLWorksheet ws = wb.Worksheet(1);
                        bool isHeader = true;

                        foreach (IXLRow dong in ws.RowsUsed())
                        {
                            if (isHeader)
                            {
                                isHeader = false;
                                continue;
                            }

                            // Format file Excel lấy ra từ hàm Xuất: 
                            // Cột 1: Mã số | Cột 2: Họ tên | Cột 3: Tên lớp | Cột 4: Số tiền | Cột 5: Ngày đóng

                            string maSo = dong.Cell(1).Value.ToString().Trim();

                            // Lọc bỏ dấu chấm phẩy nếu người dùng nhập kiểu 2,500,000
                            string strSoTien = dong.Cell(4).Value.ToString().Trim().Replace(",", "").Replace(".", "");
                            string strNgayDong = dong.Cell(5).Value.ToString().Trim();

                            if (string.IsNullOrEmpty(maSo)) continue;

                            // 1. Tìm học viên dựa vào Mã số
                            var hocVien = context.HocVien.FirstOrDefault(hv => hv.MaSo == maSo);
                            if (hocVien == null)
                            {
                                demBoQua++;
                                continue;
                            }

                            // 2. Tìm phiếu thu của học viên này TRONG LỚP ĐANG CHỌN
                            var phieuThu = context.HocPhi.FirstOrDefault(hp => hp.HocVienID == hocVien.ID && hp.LopHocID == idLopDuocChon);

                            if (phieuThu != null)
                            {
                                if (decimal.TryParse(strSoTien, out decimal soTien))
                                {
                                    phieuThu.SoTienDaDong = soTien;

                                    // Xử lý ngày đóng thông minh
                                    if (soTien > 0)
                                    {
                                        DateTime ngayDong;

                                        // CÁCH 1: Thử đọc trực tiếp kiểu Date gốc của Excel
                                        if (dong.Cell(5).TryGetValue<DateTime>(out ngayDong))
                                        {
                                            phieuThu.NgayDong = ngayDong.Date;
                                        }
                                        // CÁCH 2: Nếu Excel bị lưu dạng Text, ép phần mềm đọc theo chuẩn Ngày/Tháng/Năm
                                        else if (DateTime.TryParseExact(dong.Cell(5).GetString().Trim(),
                                                 new[] { "dd/MM/yyyy", "d/M/yyyy", "MM/dd/yyyy", "yyyy-MM-dd" },
                                                 System.Globalization.CultureInfo.InvariantCulture,
                                                 System.Globalization.DateTimeStyles.None, out ngayDong))
                                        {
                                            phieuThu.NgayDong = ngayDong.Date;
                                        }
                                        // CÁCH 3: Nếu ô Excel bỏ trống hoặc ghi chữ tào lao, tự lấy ngày hôm nay
                                        else
                                        {
                                            phieuThu.NgayDong = DateTime.Now.Date;
                                        }
                                    }

                                    // Tự động chốt trạng thái hoàn thành
                                    phieuThu.TrangThai = (soTien >= hocPhiKhoaHoc);

                                    demThanhCong++;
                                }
                                else
                                {
                                    demBoQua++; // Bỏ qua nếu cột số tiền nhập sai định dạng chữ
                                }
                            }
                            else
                            {
                                // Bỏ qua nếu Học viên có mã này nhưng chưa được ghi danh vào Lớp đang chọn
                                demBoQua++;
                            }
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show($"Cập nhật học phí thành công cho {demThanhCong} học viên.\nBỏ qua {demBoQua} dòng (do sai mã số hoặc HV chưa xếp vào lớp này).", "Hoàn tất", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load lại dữ liệu lưới
                    LoadDanhSachHocPhi(idLopDuocChon);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Có lỗi khi đọc file Excel: " + ex.Message, "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (cbbLopHoc.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn Lớp học để xuất danh sách thu tiền!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLop = cbbLopHoc.Text.Trim();
            // Lọc ký tự đặc biệt để làm tên file
            foreach (char c in System.IO.Path.GetInvalidFileNameChars())
            {
                tenLop = tenLop.Replace(c.ToString(), "_");
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Title = "Xuất danh sách học phí ra Excel";
            saveDialog.Filter = "Tập tin Excel *.xlsx|*.xlsx";
            saveDialog.FileName = $"HocPhi_{tenLop}_{DateTime.Now.ToString("dd_MM_yyyy")}.xlsx";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    DataTable dtHocPhi = new DataTable();
                    dtHocPhi.Columns.Add("Mã số", typeof(string));
                    dtHocPhi.Columns.Add("Họ và tên", typeof(string));
                    dtHocPhi.Columns.Add("Tên lớp", typeof(string));
                    dtHocPhi.Columns.Add("Số tiền đã đóng", typeof(decimal));
                    dtHocPhi.Columns.Add("Ngày đóng", typeof(string));
                    dtHocPhi.Columns.Add("Ghi chú", typeof(string));

                    var dsHienThi = dataGridView.DataSource as List<DanhSachHocPhi_ChiTiet>;
                    if (dsHienThi != null)
                    {
                        foreach (var item in dsHienThi)
                        {
                            // Tìm mã số học viên từ DB dựa vào ID
                            string maSo = context.HocVien.Find(item.HocVienID)?.MaSo ?? "";

                            // Xử lý hiển thị ngày đóng đẹp mắt
                            string ngayDong = item.SoTienDaDong == 0 ? "Chưa đóng" : item.NgayDong.ToString("dd/MM/yyyy");

                            dtHocPhi.Rows.Add(
                                maSo,
                                item.HoVaTen,
                                item.TenLop,
                                item.SoTienDaDong,
                                ngayDong,
                                item.GhiChu
                            );
                        }
                    }

                    using (XLWorkbook excelWorkbook = new XLWorkbook())
                    {
                        var excelSheet = excelWorkbook.Worksheets.Add(dtHocPhi, "ThuHocPhi");

                        // Format cột số tiền có dấu phẩy cho dễ nhìn
                        excelSheet.Column(4).Style.NumberFormat.Format = "#,##0";

                        excelSheet.Columns().AdjustToContents();
                        excelWorkbook.SaveAs(saveDialog.FileName);

                        MessageBox.Show($"Đã xuất danh sách thu tiền lớp {tenLop} ra file Excel thành công.\nThu ngân có thể dùng file này để nhập tiền và Import cập nhật lại vào phần mềm.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất file: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

