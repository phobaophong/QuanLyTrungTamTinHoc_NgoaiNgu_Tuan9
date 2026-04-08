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
            LoadBaoCao(null, null);
        }
        private void LoadBaoCao(DateTime? tuNgay, DateTime? denNgay)
        {
            try
            {
                // 1. Kéo dữ liệu từ SQL (Bảng Học Phí join với Học Viên và Lớp Học)
                var query = context.HocPhi
                    .Include(hp => hp.HocVien)
                    .Include(hp => hp.LopHoc)
                    .AsQueryable();

                string moTaThoiGian = "(Tất cả thời gian)";

                // Nếu có truyền ngày vào thì tiến hành lọc
                if (tuNgay.HasValue && denNgay.HasValue)
                {
                    query = query.Where(hp => hp.NgayDong.Date >= tuNgay.Value.Date && hp.NgayDong.Date <= denNgay.Value.Date);
                    moTaThoiGian = $"Từ ngày {tuNgay.Value:dd/MM/yyyy} đến ngày {denNgay.Value:dd/MM/yyyy}";
                }

                var danhSachPhieuThu = query.ToList();

                // 2. Cài đặt Report Viewer (Gọi thẳng vào thư mục Reports)
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
                    // Đổ đúng 4 cột như thiết kế trong DataSet1 của bạn
                    dtDoanhThu.Rows.Add(
                        item.HocVien.HoVaTen,
                        item.LopHoc.TenLopHoc,
                        item.NgayDong.Date,
                        item.SoTienDaDong
                    );
                }

                // 5. Gắn DataSource vào Report
                // LƯU Ý: Chữ "DataSet1" ở dưới phải giống y hệt tên Dataset ở cột Report Data bên trái trong file RDLC của bạn
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
                // Vẫn giữ bẫy lỗi sâu để "phòng thân"
                string msg = "Lỗi bề nổi: " + ex.Message;
                if (ex.InnerException != null) msg += "\n\n🔥 NGUYÊN NHÂN GỐC:\n" + ex.InnerException.Message;
                MessageBox.Show(msg, "Lỗi nạp báo cáo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTatCa_Click(object sender, EventArgs e)
        {
            LoadBaoCao(null, null);
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            if (dtpTuNgay.Value.Date > dtpDenNgay.Value.Date)
            {
                MessageBox.Show("Từ ngày không thể lớn hơn Đến ngày!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LoadBaoCao(dtpTuNgay.Value, dtpDenNgay.Value);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
