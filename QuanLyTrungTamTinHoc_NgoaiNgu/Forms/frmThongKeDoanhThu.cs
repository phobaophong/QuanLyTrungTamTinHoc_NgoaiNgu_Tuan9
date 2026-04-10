using DocumentFormat.OpenXml.InkML;
using Microsoft.EntityFrameworkCore;
using Microsoft.Reporting.WinForms;
using QuanLyTrungTamTinHoc_NgoaiNgu.Data;
using QuanLyTrungTamTinHoc_NgoaiNgu.Reports;
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
    public partial class frmThongKeDoanhThu : Form
    {
        QuanLyTrungTamContext context = new QuanLyTrungTamContext();

        // Dùng đúng bảng ThongKeDoanhThu từ DataSet1 của bạn
        DataSet1.ThongKeDoanhThuDataTable dtDoanhThu = new DataSet1.ThongKeDoanhThuDataTable();
        public frmThongKeDoanhThu()
        {
            InitializeComponent();

            Models.Utils.GiaoDien.ApDungGiaoDien(this);
        }

        private void frmThongKeDoanhThu_Load(object sender, EventArgs e)
        {
            LoadCbbKhoaHoc();

            LoadBaoCao(null, null, 0);
        }
        private void LoadCbbKhoaHoc()
        {
            var kh = context.KhoaHoc.Where(k => k.HocPhi > 0).ToList();

            // Thêm một dòng "Tất cả" lên đầu danh sách để cho phép xem tổng doanh thu
            kh.Insert(0, new KhoaHoc { ID = 0, TenKhoaHoc = "-- Tất cả Khóa học --" });

            cboKhoaHoc.DataSource = kh;
            cboKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboKhoaHoc.ValueMember = "ID";
        }
        private void LoadCbbLopHoc(int idKhoa)
        {
            if (idKhoa == 0)
            {
                // Nếu chọn Tất cả khóa học -> Chỉ hiển thị Tất cả lớp học
                cboLopHoc.DataSource = new List<LopHoc> { new LopHoc { ID = 0, TenLopHoc = "-- Tất cả Lớp học --" } };
            }
            else
            {
                var lop = context.LopHoc.Where(x => x.KhoaHocID == idKhoa).ToList();
                lop.Insert(0, new LopHoc { ID = 0, TenLopHoc = "-- Tất cả Lớp học --" });
                cboLopHoc.DataSource = lop;
            }

            cboLopHoc.DisplayMember = "TenLopHoc";
            cboLopHoc.ValueMember = "ID";
        }
        private void LoadBaoCao(DateTime? tuNgay, DateTime? denNgay, int idLop)
        {
            try
            {
                // 1. Kéo dữ liệu từ SQL
                var query = context.HocPhi
                    .Include(hp => hp.HocVien)
                    .Include(hp => hp.LopHoc)
                    .AsQueryable();

                string moTaThoiGian = "(Tất cả thời gian)";

                // Lọc theo thời gian
                if (tuNgay.HasValue && denNgay.HasValue)
                {
                    query = query.Where(hp => hp.NgayDong.Date >= tuNgay.Value.Date && hp.NgayDong.Date <= denNgay.Value.Date);
                    moTaThoiGian = $"Từ ngày {tuNgay.Value:dd/MM/yyyy} đến ngày {denNgay.Value:dd/MM/yyyy}";
                }

                // 🔥 Lọc theo Lớp Học (Nếu có chọn lớp cụ thể, idLop > 0)
                if (idLop > 0)
                {
                    query = query.Where(hp => hp.LopHocID == idLop);
                    var lopDangChon = context.LopHoc.Find(idLop);
                    if (lopDangChon != null)
                    {
                        moTaThoiGian += $" - Thuộc lớp: {lopDangChon.TenLopHoc}";
                    }
                }

                var danhSachPhieuThu = query.ToList();

                // 2. Cài đặt Report Viewer
                reportViewer1.LocalReport.ReportPath = @"Reports\rptThongKeDoanhThu.rdlc";

                // 3. Đổ dữ liệu cho biến [@ThoiGianLoc]
                ReportParameter[] p = new ReportParameter[]
                {
                    new ReportParameter("ThoiGianLoc", moTaThoiGian)
                };
                reportViewer1.LocalReport.SetParameters(p);

                // 4. Bơm dữ liệu vào DataTable
                dtDoanhThu.Clear();
                foreach (var item in danhSachPhieuThu)
                {
                    // 🔥 XỬ LÝ LOGIC NGÀY ĐÓNG LÀ 0 THÌ HIỂN THỊ "CHƯA ĐÓNG"
                    // (Yêu cầu cột NgayDong trong DataSet1.xsd phải là kiểu String)
                    string ngayDongHienThi = "";

                    if (item.SoTienDaDong == 0)
                    {
                        ngayDongHienThi = "Chưa đóng";
                    }
                    else
                    {
                        ngayDongHienThi = item.NgayDong.ToString("dd/MM/yyyy");
                    }

                    dtDoanhThu.Rows.Add(
                        item.HocVien.HoVaTen,
                        item.LopHoc.TenLopHoc,
                        ngayDongHienThi, // Biến này giờ là một chuỗi (string)
                        item.SoTienDaDong
                    );
                }

                // 5. Gắn DataSource vào Report
                ReportDataSource rds = new ReportDataSource("DataSet1", (DataTable)dtDoanhThu);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(rds);

                // 6. Refresh
                reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
                reportViewer1.ZoomMode = ZoomMode.Percent;
                reportViewer1.ZoomPercent = 100;
                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                string msg = "Lỗi bề nổi: " + ex.Message;
                if (ex.InnerException != null) msg += "\n\n🔥 NGUYÊN NHÂN GỐC:\n" + ex.InnerException.Message;
                MessageBox.Show(msg, "Lỗi nạp báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            if (cboKhoaHoc.Items.Count > 0) cboKhoaHoc.SelectedIndex = 0;
            if (cboLopHoc.Items.Count > 0) cboLopHoc.SelectedIndex = 0;

            LoadBaoCao(null, null, 0);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn Đến ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 🔥 LẤY ID LỚP ĐANG CHỌN ĐỂ TRUYỀN VÀO HÀM LỌC
            int idLopDangChon = 0;
            if (cboLopHoc.SelectedValue != null && cboLopHoc.SelectedValue is int id)
            {
                idLopDangChon = id;
            }

            LoadBaoCao(dtpTuNgay.Value, dtpDenNgay.Value, idLopDangChon);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboKhoaHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboKhoaHoc.SelectedValue != null && cboKhoaHoc.SelectedValue is int idKhoa)
            {
                LoadCbbLopHoc(idKhoa);
            }
        }

        private void cboLopHoc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
